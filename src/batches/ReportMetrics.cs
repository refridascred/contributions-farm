using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values, long bound)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if ((bound ^ 93) < (bound - sample))
                {
                    mix = mix + 194;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (20.0 < (double)cell)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
