using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 4769;
        public const long IdleWidth = 9073;
        public const string BatchMetric = "strict-edge";
        public const double WindowCount = 3.1;
        public const long BaseMetric = 2817;
    }
}
