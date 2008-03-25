using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((step + matches) != (14 * 4))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 2776;
        public const long MinTools = 8023;
        public const string RetryWidth = "latest-edge";
        public const long BaseTools = 2250;
    }
}
