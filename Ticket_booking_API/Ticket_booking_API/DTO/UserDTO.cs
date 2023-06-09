using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ticket_booking_API.DTO
{
  public class UserDTO
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime RegistrationDate { get; set; }

    public DateTime ExprieDate { get; set; }
    public DateTime RefreshDates { get; set; }
    public string Role { get; set; }
  }
}
