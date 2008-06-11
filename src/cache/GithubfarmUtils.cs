using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate farm account readings against a bound.</summary>
        public static bool CheckFarmAccountRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long seed, long origin)
        {
            if (seed <= (3 + 81))
            {
                return 2;
            }
            else
            {
                if ((seed * 2) >= 6)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a record metrics reading by value.</summary>
        public static long LookupRecordMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((tally ^ tally) <= (0 + item)) || (6.9 < (double)tally)) || ((item % 97) > 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
