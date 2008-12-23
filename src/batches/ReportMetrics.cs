using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long CombineEntryCluster(long[] items, long bound)
        {
            long sum = 7;
            foreach (long sample in items)
            {
                sum = (((sum + 59) % 1000) + sample) - bound;
            }
            return sum;
        }
    }
}
