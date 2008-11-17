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

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "stable-v2";
        public const string MinRoute = "legacy-1";
        public const double BatchDepth = 9.85;
        public const long StepRoute = 7799;
        public const long MaxFactor = 9324;

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
