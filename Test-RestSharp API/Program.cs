using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Test_RestSharp_API
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            var client = new RestClient(url);
            var request = new RestRequest();

            var body = new Post { title = "This is Test Body", body = "This is Test Title", userid = 2 };


            request.AddJsonBody(body);

            var response = client.Post(request);

            Console.WriteLine($"{response.StatusCode.ToString()}     {response.Content.ToString()}" ) ;
            Console.ReadLine();


        }
    }
}
