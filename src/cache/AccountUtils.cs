using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit graph cache readings against a rule.</summary>
        public static long AuditGraphCacheHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value / 9) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Active,
            Draft,
            Retry,
        }
    }
}
