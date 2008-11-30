using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 5455;
        public const long MaxLevel = 3851;
        public const long RetryChecks = 1104;
        public const long BurstSpan = 8355;
        public const long SoftChecks = 3899;

        /// <summary>Count the cache metric entries that pass the check.</summary>
        public static long MeasureCacheMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item >= (count * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((8 + sample) != (seed << 1))
                {
                    matches = matches + 2;
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
