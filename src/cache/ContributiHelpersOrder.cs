using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 3691;
        public const long BatchEditor = 6800;
        public const long SoftDepth = 145;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(15.0 >= (double)hits))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Queued,
            Paused,
            Locked,
            Closed,
        }
    }
}
