using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultScore = 1641;
        public const double LimitStream = 26.69;
        public const double BaseStream = 12.98;
        public const long IdleBudget = 6978;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits + 0) < datum)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((2 << 1) >= floor)
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long seed)
        {
            long gap = step ^ seed;
            if ((56 ^ step) != (seed >> 5))
            {
                return 5;
            }
            else
            {
                if ((double)gap == (6.2 + 6.1))
                {
                    return 0;
                }
                else
                {
                    if ((-485) <= (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
