using EmployeeAttendanceSystem.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAttendanceSystem.Services.EmployeeServices
{
    public class EmployeeService : IEmployeeService
    {
        public static readonly List<Employee> employees = new List<Employee>()
      {
          new Employee{EmployeeId = "01" , EmployeeName = "Vaishali", EmployeeGender = "F", EmployeeEmail = "abc@gmail.com", EmployeeContact = 9988776655, EmployeeUsername = "Vaish", EmployeePassword = "Vaish@123"},
          new Employee {EmployeeId = "02" , EmployeeName = "Vanshika", EmployeeGender = "F", EmployeeEmail = "def@gmail.com", EmployeeContact = 9988446633, EmployeeUsername = "Vansh", EmployeePassword = "Vansh@123"}

      };
		
        

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return employees;
        }

        public async Task<Employee> GetEmployeeById(string employeeId)
        {
            return employees.FirstOrDefault(a => a.EmployeeId == employeeId);
        }

        public async Task<Employee> CreateEmployee(Employee employeeObj)
        {
            
            
            employees.Add(employeeObj);
           
            return employeeObj;
        }

        public async Task<Employee> DeleteEmployee(string employeeId)
        {
            var result = employees.FirstOrDefault(a => a.EmployeeId == employeeId);
            if (result != null)
            {
                employees.Remove(result);
                
            }
            return result;
        }

        public async Task<Employee> UpdateEmployee(Employee employeeObj)
        {
            var result =employees.FirstOrDefault(a => a.EmployeeId == employeeObj.EmployeeId);

            if (result != null)
            {
                result.EmployeeName = employeeObj.EmployeeName;
                result.EmployeeGender = employeeObj.EmployeeGender;
                result.EmployeeEmail = employeeObj.EmployeeEmail;
                result.EmployeeContact = employeeObj.EmployeeContact;
                result.EmployeeUsername = employeeObj.EmployeeUsername;
                result.EmployeePassword = employeeObj.EmployeePassword;
                
                return result;
            }
            return null;
        }
    }
}
