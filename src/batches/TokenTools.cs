using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardDepth = 5292;
        public const long RetrySupport = 7955;
        public const long DefaultSpan = 1894;
        public const string CacheSupport = "cached-v2";

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
