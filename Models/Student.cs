using System.ComponentModel.DataAnnotations;

namespace bai_thuc_hanh_1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        [Required(ErrorMessage ="Không để trống name")]
        [StringLength(100,MinimumLength =4,ErrorMessage = "Tên sinh viên phải từ 4 kí tự trở lên")]
        public string? Name { get; set; } //Họ tên
        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-za-z0-9]+@gmail.com",ErrorMessage ="Đuôi email phải là gmail.com")]
        public string? Email { get; set; } //Email
        [Required(ErrorMessage = "Password bắt buộc phải được nhập")]
        [StringLength(100, MinimumLength = 8,ErrorMessage = "Password phải từ 8 kí tự trở lên")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}", ErrorMessage = "Password ít nhất có một chữ hoa, chữ thường, số và kí tự đặc biệt")]
        public string? Password { get; set; }//Mật khẩu
        [Required]
        public Branch? Branch { get; set; }//Ngành học
        [Required(ErrorMessage = "Không để trống")]
        public Gender? Gender { get; set; }//Giới tính

        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Không để trống địa chỉ")]
        public string? Address { get; set; }//Địa chỉ
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005",ErrorMessage = "Ngày sinh trong khoảng 1/1/1963 - 12/31/2005")]
        [DataType(DataType.Date,ErrorMessage ="Không nhập đúng định dạng")]
        [Required(ErrorMessage = "Không để trống ngày sinh")]
        public DateTime DateOfBirth { get; set; }//Ngày sinh
        [Required(ErrorMessage = "Không để trống")]
        [Range(typeof(double), "0.0", "10.0",ErrorMessage = "Giá trị phải giữa 0 và 10")]
        public double Mark {  get; set; }
    }
}