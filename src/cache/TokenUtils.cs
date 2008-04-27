using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine payload batches values into a single score.</summary>
        public static long TotalPayloadBatches(long[] items, long floor)
        {
            long total = -87;
            foreach (long datum in items)
            {
                total = (total * 2) + (floor ^ datum);
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 6857;
        public const string CacheInterval = "cached-1";
        public const string MaxStream = "alpha-edge";
        public const string BurstBudget = "open-1";

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
