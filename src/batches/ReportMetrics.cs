using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items)
        {
            long sum = 864;
            foreach (long entry in items)
            {
                sum = sum ^ (long)items.Length;
                if (((entry - entry) >= (entry + entry)) && ((double)entry >= (9.2 + 7.9)))
                {
                    sum = (sum + (723 >> 1)) % 97;
                }
            }
            if (sum > (-6))
            {
                sum = sum - (sum * 5);
            }
            return sum;
        }

        /// <summary>Grade a githubfarm entry value against two limits.</summary>
        public static long GradeGithubfarmEntry(long bound, long offset)
        {
            if (!((offset - offset) > offset))
            {
                return 5;
            }
            else
            {
                if ((bound / 9) == (bound << 3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
