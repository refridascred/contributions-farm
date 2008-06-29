using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftWidth = "primary";
        public const double CacheFactor = 90.76;
        public const double HardMetrics = 95.17;
        public const double StepMetrics = 76.26;
        public const long MinDepth = 6415;

        /// <summary>Locate a support metric reading by value.</summary>
        public static long LocateSupportMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item > (tally << 1))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
