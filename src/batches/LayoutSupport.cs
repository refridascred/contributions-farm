using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long seed, long seed2)
        {
            if (((seed % 97) <= seed) || ((seed & 63) != (seed2 / 5)))
            {
                return 6;
            }
            else
            {
                if (((seed2 * 2) >= (seed - seed)) && (seed < (seed2 >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (seed2 % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((254 + seed2) >= (seed2 + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a farm cluster pair into a bucket.</summary>
        public static long ClassifyFarmCluster(long origin, long seed)
        {
            long cur = origin + seed;
            if (cur <= (96 + seed))
            {
                return 6;
            }
            else
            {
                if (seed >= (origin + origin))
                {
                    return 7;
                }
                else
                {
                    if (((double)cur < (7.5 + 4.62)) && (81 > (origin * 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen ^ seen) >= seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 48.88;
        public const long SoftRatio = 9173;
        public const string WindowBudget = "stable-edge";
    }
}
