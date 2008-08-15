using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long bound, long step)
        {
            if ((16 > (4 - bound)) && ((step + (-2)) != (step + step)))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (6.99 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound >= (4.0 * 7.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound >> 1) <= (step ^ bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a githubfarm booking reading by value.</summary>
        public static long LookupGithubfarmBookingIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
