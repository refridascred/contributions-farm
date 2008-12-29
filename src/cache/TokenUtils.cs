using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Failed,
            Active,
        }
    }
}
