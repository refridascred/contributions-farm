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

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxDepth = 9580;
        public const long BatchLayout = 5005;
        public const double WindowLayout = 3.3;
        public const long LimitBudget = 778;
        public const long DefaultSpan = 3525;

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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long origin, long offset)
        {
            if ((offset + origin) < (-518))
            {
                return 5;
            }
            else
            {
                if ((double)origin > 4.3)
                {
                    return 2;
                }
                else
                {
                    if ((origin & 7) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
