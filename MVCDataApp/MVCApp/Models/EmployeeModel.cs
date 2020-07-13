using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Range(1, 10000, ErrorMessage = "You must enter a valid employee ID!")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="You must provide a first name")]
        public string FirstName { get; set; }
       
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must provide a last name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "You must provide a email name")]

        public string EmailAddress { get; set; }
      
        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress",ErrorMessage ="The email and confirm email must match")]
        public string ConfirmEmail { get; set; }
      
        [Display(Name = "Password")]

        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength = 10)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="The password and confirm password must match")]
        [Display(Name = "Confirm Password")]
        

        public string ConfirmPassword { get; set; }

    }
}