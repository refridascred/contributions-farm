using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3094;
        public const double CacheDepth = 58.73;
        public const long IdleCount = 2224;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 5633;
        public const double MaxCount = 25.25;
        public const long MaxDepth = 195;
        public const double HardStats = 73.57;
        public const string DefaultFactor = "local-v2";

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
