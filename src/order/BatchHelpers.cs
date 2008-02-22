using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Active,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit metric context readings against a rule.</summary>
        public static long MeasureMetricContextGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry >> 5) >= floor)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
