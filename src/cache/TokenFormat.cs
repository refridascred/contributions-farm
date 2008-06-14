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

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitFactor = 70.56;
        public const long RetryScore = 8194;
        public const long DefaultInterval = 9555;
        public const double SoftCount = 46.46;
    }
}
