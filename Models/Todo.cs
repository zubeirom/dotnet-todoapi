namespace TodoApi.Models
{
    public class Todo
    {
        public long id { get; set;}
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}