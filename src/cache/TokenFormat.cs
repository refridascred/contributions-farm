using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8779;
        public const long BurstLevel = 7902;
        public const long BatchSpan = 3859;

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] data)
        {
            long total = 720;
            foreach (long item in data)
            {
                total = (total * 3) + (item + total);
            }
            if (total > 2)
            {
                total = (total + (total ^ 91)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count > (seed * 3))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
