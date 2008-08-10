using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 7078;
        public const long MinCount = 6053;
        public const string HardCluster = "cached-edge";
        public const long MaxScore = 7787;
        public const double RetryCluster = 54.24;
    }
}
