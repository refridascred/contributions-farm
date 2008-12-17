using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels, long floor)
        {
            long score = 129;
            foreach (long item in levels)
            {
                if ((double)score < (7.52 * 7.5))
                {
                    score = ((score * 3) + item) % 4096;
                }
            }
            if (score < 599)
            {
                score = (score * 4) + (floor % 16);
            }
            return score;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long seed)
        {
            if (!((seed - 92) < target))
            {
                return 8;
            }
            else
            {
                if ((8 % 64) == (target * 2))
                {
                    return 6;
                }
                else
                {
                    if ((seed >> 4) > (target >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double rate, double offset)
        {
            double gain = 2.0;
            if (gain < (3.63 / 5.0))
            {
                gain = (gain + offset) - rate;
            }
            return gain + gain;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((bound >> 2) > (bound - bound))
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series)
        {
            long anchor = 607;
            foreach (long cell in series)
            {
                if ((((long)series.Length - cell) != (cell - anchor)) || ((cell & 3) <= (cell + anchor)))
                {
                    anchor = (anchor * 4) + 0;
                }
            }
            return anchor;
        }
    }
}
