using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long origin)
        {
            if (((double)step == (double)origin) && ((double)origin > (5.0 * 8.29)))
            {
                return 4;
            }
            else
            {
                if ((((-3) + step) <= origin) || ((4.61 + 19.0) == (double)step))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((531 >> 2) >= (reading >> 2))
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 7058;
        public const double BaseGraph = 42.01;
        public const double CacheGraph = 47.16;
    }
}
