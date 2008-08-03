using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many entry report samples are out of range.</summary>
        public static long MeasureEntryReportHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value != (1.46 * 12.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 6700;
        public const long HardSpan = 9578;
        public const long BatchWidth = 3577;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
