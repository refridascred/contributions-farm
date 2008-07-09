using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Synced,
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 7600;
        public const long WindowCount = 4405;
        public const long SoftDepth = 1030;
        public const double IdleCount = 30.78;
    }
}
