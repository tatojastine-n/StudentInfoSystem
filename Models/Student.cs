using System.ComponentModel.DataAnnotations;

namespace StudentInformationSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
