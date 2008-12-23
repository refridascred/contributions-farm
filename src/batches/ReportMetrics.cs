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

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((456 + 2) == (count - entry)))
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
