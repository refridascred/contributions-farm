using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value == (0.1 * 6.6))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits % 64) < origin)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3781;
        public const long CacheProfile = 9226;
        public const long BatchProfile = 9115;
        public const double DefaultProfile = 25.58;
    }
}
