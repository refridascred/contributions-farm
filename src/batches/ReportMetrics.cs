using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ value) < value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Ready,
            Paused,
        }
    }
}
