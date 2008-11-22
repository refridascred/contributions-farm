using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "open-v2";
        public const long BurstFactor = 1177;
        public const string IdleCounter = "staging-edge";
        public const long LimitDepth = 2582;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryFactor = 4001;
        public const string BurstTimeout = "cached-1";
        public const long WindowReport = 2843;
        public const long HardDepth = 8730;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Weight { get; set; }
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
