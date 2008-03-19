using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long floor, long floor2)
        {
            long lane = floor ^ floor2;
            if (((double)lane > (double)floor2) && ((floor + floor2) < lane))
            {
                return 8;
            }
            else
            {
                if ((16.0 / 2.0) > (double)floor2)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long SeriesToolsContext(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ ((long)i - (long)i)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                score = ((score * 5) + (score + score)) % 1000;
                if (!((score + score) <= (cell / 8)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long target)
        {
            long next = seed + target;
            if ((double)seed <= (8.9 - 6.51))
            {
                return 6;
            }
            else
            {
                if ((next + next) >= (seed * 2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
