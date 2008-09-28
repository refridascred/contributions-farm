using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            Pending,
            Draft,
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
