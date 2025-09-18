using Soenneker.Quark.Offcanvases.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Offcanvases.Tests;

[Collection("Collection")]
public sealed class OffcanvasInteropInteropTests : FixturedUnitTest
{
    private readonly IOffcanvasInterop _blazorlibrary;

    public OffcanvasInteropInteropTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _blazorlibrary = Resolve<IOffcanvasInterop>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
