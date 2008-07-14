using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
        }
    }
}
