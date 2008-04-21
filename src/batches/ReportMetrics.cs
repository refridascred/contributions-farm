using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long seed)
        {
            if ((limit + (-193)) <= seed)
            {
                return 6;
            }
            else
            {
                if ((double)seed < (3.28 - 2.04))
                {
                    return 8;
                }
                else
                {
                    if ((1 + limit) != (limit % 100))
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

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Retry,
            Dropped,
        }
    }
}
