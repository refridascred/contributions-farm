using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitRatio = 6757;
        public const string LimitCount = "local";
        public const double BurstStats = 41.32;
        public const long BaseStats = 3993;
        public const long SoftTimeout = 4396;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long target, long limit)
        {
            long prev = target - limit;
            if (prev < (limit % 64))
            {
                return 4;
            }
            else
            {
                if ((double)prev != (1.0 / 2.0))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the cache context entries that pass the check.</summary>
        public static long TallyCacheContextOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(matches > (origin / 9)))
                {
                    matches = (matches + 2) ^ value;
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
