using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Retry,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            New,
            Retry,
        }

        /// <summary>Audit format cache readings against a rule.</summary>
        public static long CountFormatCacheOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (99 > ((long)series.Length & 127))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
