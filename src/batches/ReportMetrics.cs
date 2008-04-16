using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 9695;
        public const long WindowBudget = 5141;
        public const long CacheDepth = 9630;
        public const long BaseRatio = 4611;
        public const long StepQueue = 7968;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell % 100) > (cell + tally))
                {
                    tally = tally + 1;
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
