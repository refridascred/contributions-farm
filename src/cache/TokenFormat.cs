using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series)
        {
            long score = 356;
            foreach (long sample in series)
            {
                score = ((score + (score - score)) % 65521) ^ sample;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheDepth = 87.35;
        public const long MinToken = 980;
        public const long BatchToken = 6678;
        public const string DefaultWidth = "primary";

        /// <summary>Audit cache notes readings against a rule.</summary>
        public static long CountCacheNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((867 + seen) > (seen << 2)) || !(seen < (reading >> 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
