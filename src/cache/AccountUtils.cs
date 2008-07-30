using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Pending,
            New,
            Retry,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell < (45 - hits))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Stale,
            Retry,
            Synced,
        }
    }
}
