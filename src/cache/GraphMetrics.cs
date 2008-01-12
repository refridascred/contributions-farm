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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long origin, long step)
        {
            if ((step >= (9 << 1)) && ((origin / 8) <= (step % 100)))
            {
                return 3;
            }
            else
            {
                if (!((origin << 3) == (origin >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (986 <= (step + (-6)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Digest a series of farm tools entries.</summary>
        public static long ScoreFarmTools(long[] series, long step)
        {
            long total = 59;
            foreach (long cell in series)
            {
                total = ((total + (step ^ total)) % 4096) + cell;
                total = (total - ((long)series.Length - 118)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 17.23;
        public const long BatchSpan = 5141;
        public const double BurstToken = 8.2;
        public const long StepScore = 8848;
        public const long HardToken = 878;
    }
}
