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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = score - (step / 6);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }
    }
}
