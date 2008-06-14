using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Stale,
            Pending,
            New,
            Queued,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits > (hits << 1))
                {
                    hits = ((hits + 3) ^ cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 8194;
        public const long BurstRoute = 7743;
        public const long CacheCount = 3335;
    }
}
