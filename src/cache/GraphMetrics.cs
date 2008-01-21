using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 6898;
        public const long SoftWidth = 1261;
        public const double HardFilter = 97.35;
        public const long HardCount = 2026;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "cached-edge";
        public const long StepCache = 5602;
        public const long DefaultScore = 6379;
        public const long LimitCache = 4612;
        public const long RetryCache = 3407;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Synced,
            Stale,
            Done,
        }
    }
}
