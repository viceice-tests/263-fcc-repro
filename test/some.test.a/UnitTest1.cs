using NUnit.Framework;
using Some.LibA;

namespace Some.Test.A;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.DoesNotThrow(()=> Class1.Do());
    }
}