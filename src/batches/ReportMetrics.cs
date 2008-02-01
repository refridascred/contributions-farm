using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (6 >= seen)
                {
                    seen = ((seen + 2) + value) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
