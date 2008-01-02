using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the context stats entries that pass the check.</summary>
        public static long CountContextStatsHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)325 > (double)value)
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleBudget = 18.12;
        public const string CacheWidth = "staging";
        public const long MaxFarm = 5077;
        public const long BaseWidth = 9357;
    }
}
