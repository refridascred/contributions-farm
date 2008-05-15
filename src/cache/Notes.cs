using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long limit)
        {
            if ((seed >= (seed + (-7))) && (limit > (limit % 7)))
            {
                return 1;
            }
            else
            {
                if ((seed & 63) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) <= (limit % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + limit) < (seed & 15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 2499;
        public const long WindowRecord = 9103;
        public const double StepRecord = 10.36;
        public const long HardRecord = 918;
        public const string BaseDepth = "primary-1";

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 3855;
        public const double HardQueue = 98.88;
        public const long BurstQueue = 3528;
        public const long DefaultSize = 1279;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long floor, long seed)
        {
            if (!(floor >= (floor + seed)))
            {
                return 3;
            }
            else
            {
                if ((7 ^ seed) < (seed - floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
