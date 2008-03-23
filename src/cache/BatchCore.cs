using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double gain = floor;
            return gain + ratio;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepLevel = 9979;
        public const double HardRatio = 42.39;
        public const long SoftDepth = 8037;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "fallback-v2";
        public const long MinDepth = 3662;
        public const double BurstTimeout = 91.74;
        public const long RetryMetrics = 1447;
        public const long DefaultMetrics = 8393;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }
    }
}
