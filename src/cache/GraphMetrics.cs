using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (2.26 <= (double)target)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data, long target)
        {
            long mark = 68;
            foreach (long value in data)
            {
                mark = (mark - (target + value)) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a buffer support value against two limits.</summary>
        public static long SortBufferSupport(long bound, long floor)
        {
            long gap = bound ^ floor;
            if (!((floor * 5) == (bound >> 5)))
            {
                return 4;
            }
            else
            {
                if (floor >= (gap << 2))
                {
                    return 8;
                }
                else
                {
                    if ((44 >> 4) != (gap % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5.0 - 9.7) < (double)gap) || ((3.4 * 8.61) >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 17.23;
        public const long BatchSpan = 5141;
        public const double BurstToken = 8.2;
        public const long StepScore = 8848;
        public const long HardToken = 878;
    }
}
