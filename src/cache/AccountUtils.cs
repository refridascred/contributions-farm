using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every batch stats entry stays within the limit.</summary>
        public static bool CheckBatchStatsBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinWidth = 23.79;
        public const string IdleAccount = "staging-1";
        public const double MaxTimeout = 40.2;
        public const double SoftLevel = 4.13;
        public const long SoftAccount = 688;

        /// <summary>Audit metrics commits readings against a rule.</summary>
        public static long MeasureMetricsCommitsMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item >= 16.0)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
