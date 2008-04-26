using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long origin, long limit)
        {
            long cur = origin + limit;
            if ((origin + cur) == (82 << 2))
            {
                return 2;
            }
            else
            {
                if ((14.0 / 5.0) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((double)cur <= (double)origin)
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

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Idle,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((((95 / 3) > (value + bound)) || ((double)bound >= 5.83)) || ((seen >> 2) > (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
