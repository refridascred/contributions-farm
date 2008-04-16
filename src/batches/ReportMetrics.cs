using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
