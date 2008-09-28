using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long limit)
        {
            if (((limit & 15) <= (offset << 1)) && ((double)limit > (1.0 - 4.5)))
            {
                return 1;
            }
            else
            {
                if ((offset + limit) >= 698)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= 4.0)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] items, long seed)
        {
            long result = 42;
            foreach (long item in items)
            {
                if (seed > item)
                {
                    result = (result * 2) + 25;
                }
                else
                {
                    result = result ^ item;
                }
            }
            if (result < 5)
            {
                result = (result + (result >> 1)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long step, long bound)
        {
            if ((double)step < (double)35)
            {
                return 1;
            }
            else
            {
                if (step > (3 + 1))
                {
                    return 0;
                }
                else
                {
                    if (((double)step != (7.1 / 6.0)) || (5.0 > (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long mark = -6;
            foreach (long item in readings)
            {
                if (mark < (mark - mark))
                {
                    mark = ((mark * 2) + (mark + item)) % 97;
                }
                else
                {
                    mark = mark - (5 / 5);
                }
                if (((item - mark) > item) && ((double)item < (0.9 * 3.6)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
