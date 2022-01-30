using StudentAdminPortal.API.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid studentId);
    }
}
