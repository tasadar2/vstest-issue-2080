using System.Threading;
using Xunit;

namespace Project.UnitTests
{
    public class TestClass
    {
        [Fact]
        public void Test()
        {
            Thread.Sleep(5000);
        }
    }
}
