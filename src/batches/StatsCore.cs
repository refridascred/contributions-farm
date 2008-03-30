using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Score { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the payload stream entries that pass the check.</summary>
        public static long MeasurePayloadStreamOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)origin == (double)354)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheSpan = "alpha-v2";
        public const long StepFormat = 3643;
        public const long LimitFormat = 1652;
        public const string HardFormat = "strict";
        public const long BurstFactor = 3026;

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double bias)
        {
            double gain = ratio;
            if (gain <= (double)129)
            {
                gain = (gain + (3.62 - ratio)) + bias;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 9.63) - (double)(long)i;
            }
            return gain - (16.0 * 1.6);
        }
    }
}
