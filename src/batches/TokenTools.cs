using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Done,
            Pending,
            Closed,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
