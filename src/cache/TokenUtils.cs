using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Dropped,
            Queued,
            New,
            Paused,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 30.63;
        public const long BaseCache = 5589;
        public const long HardInterval = 7004;
        public const long RetryCache = 9573;
    }
}
