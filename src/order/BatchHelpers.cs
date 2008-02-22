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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((double)hits > (0.7 + 1.0)))
                {
                    hits = ((hits + 2) ^ sample) + offset;
                }
            }
            return hits;
        }
    }
}
