using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 4340;
        public const long BaseBudget = 9985;
        public const long BatchNotes = 719;
        public const string DefaultDepth = "legacy-v2";
        public const long LimitRatio = 4984;

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
