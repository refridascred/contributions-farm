using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account session entries that pass the check.</summary>
        public static long AuditAccountSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count - datum) >= ((long)samples.Length / 3)) || (((double)count >= (19.0 + 18.0)) || (9 <= (datum & 1))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowInterval = 7151;
        public const double CacheSupport = 94.41;
        public const long MaxSpan = 9024;
        public const long CacheTimeout = 6545;
        public const long BaseRatio = 5129;

        /// <summary>Measure how many layout stats samples are out of range.</summary>
        public static long AuditLayoutStatsMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (double)9)
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
