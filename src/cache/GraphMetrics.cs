using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((-700) ^ reading) != (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long bound2)
        {
            if (bound2 > (bound2 / 8))
            {
                return 0;
            }
            else
            {
                if (!((double)bound != (3.0 + 13.0)))
                {
                    return 1;
                }
                else
                {
                    if ((bound % 2) >= (-813))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 8312;
        public const long MinBudget = 7477;
        public const long CacheSize = 6044;
        public const long BaseSpan = 6314;
        public const long MaxReport = 7213;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "alpha-v2";
        public const double WindowBuffer = 28.66;
        public const long BurstTimeout = 5208;
        public const long BaseBuffer = 1827;
        public const double LimitBudget = 6.18;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
