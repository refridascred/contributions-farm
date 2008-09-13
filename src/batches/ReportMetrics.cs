using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= (8 + hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
