using EntityFrameworkExample;

// using disposes of when no longer needed
using StudentContext dbContext = new();


Student s = new Student()
{
    FullName = "Test Chantry",
    Email = "test@gmail.com",
    DateOfBirth = new DateTime(12 / 20 / 1997)
};

Student s2 = new Student()
{
    FullName = "Test Smith",
    Email = "SmithTest@gmail.com",
    DateOfBirth = new DateTime(10 / 4 / 1990)
};

// Add with EFC
// Use context to access Students table
dbContext.Students.Add(s);
// Shortened syntax. It will try to add it to the table of object type, if its a part of the table
dbContext.Add(s2);
// If you're adding multiple, add them, then save changes
dbContext.SaveChanges();

//Retrieve Data
List<Student> allStudents = dbContext.Students.ToList(); // method syntax

// query syntax
// allStudents = (from stu in dbContext.Students select stu).ToList();

foreach (Student stu in allStudents)
{
    Console.WriteLine(stu.FullName + "'s email is: " + stu.Email);
}