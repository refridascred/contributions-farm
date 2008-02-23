using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Failed,
            Stale,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (5.8 + 0.2))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Closed,
            Done,
            Ready,
            Queued,
        }
    }
}
