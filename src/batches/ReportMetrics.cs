using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum * 5) >= (hits << 2)) || (((double)hits == (5.72 / 9.0)) && ((double)(long)values.Length <= (8.2 * 1.66))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 6056;
        public const double WindowCluster = 91.85;
        public const double MinCluster = 89.06;
        public const long StepCluster = 7461;
        public const long BurstFactor = 8184;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Ready,
            New,
        }
    }
}
