using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Ready,
            Idle,
            New,
        }

        /// <summary>Count the commits layout entries that pass the check.</summary>
        public static long AuditCommitsLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((5.14 / 2.0) < (double)datum) && ((double)datum != (5.85 + 6.8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Done,
            Ready,
            Queued,
        }
    }
}
