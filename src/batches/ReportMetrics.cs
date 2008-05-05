using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((2.46 + 9.8) == (double)cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
