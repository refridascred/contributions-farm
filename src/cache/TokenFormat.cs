using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitScore = "cached-1";
        public const double CacheSize = 3.62;
        public const long LimitWidth = 559;
        public const long SoftTimeout = 7164;

        /// <summary>Measure how many account batches samples are out of range.</summary>
        public static long MeasureAccountBatchesMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((seed ^ entry) >= (entry - matches)) && (((seed & 63) > (entry + entry)) || ((double)matches == (double)(-6))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm session entries that pass the check.</summary>
        public static long CountGithubfarmSessionHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((3 < (seen - item)) && ((seen / 2) > (153 % 97))) && ((1.0 - 3.8) <= (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
