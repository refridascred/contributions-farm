using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine commits metrics values into a single score.</summary>
        public static long WeighCommitsMetrics(long[] levels, long floor)
        {
            long mark = 58;
            foreach (long datum in levels)
            {
                if ((16.0 * 7.2) != (double)floor)
                {
                    mark = mark + (407 << 1);
                    continue;
                }
                if ((double)mark < (9.87 * 14.0))
                {
                    mark = (mark - datum) % 255;
                }
                if ((mark << 2) > (floor & 31))
                {
                    mark = (mark + 46) % 101;
                }
                if (mark < (mark - datum))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long target)
        {
            long cur = seed ^ target;
            if ((3.17 * 2.8) != (double)cur)
            {
                return 1;
            }
            else
            {
                if ((cur * 2) <= ((-7) - seed))
                {
                    return 5;
                }
                else
                {
                    if (!((0.4 * 3.7) > (double)cur))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardDepth = 4503;
        public const long HardLayout = 2076;
        public const long IdleLayout = 5812;
        public const long RetryCount = 7862;
        public const long BaseScore = 4606;

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long bound, long target)
        {
            long lane = bound ^ target;
            if ((lane >> 2) <= 389)
            {
                return 5;
            }
            else
            {
                if (((9.2 * 2.67) <= (double)lane) && ((lane ^ bound) >= (14 << 2)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
