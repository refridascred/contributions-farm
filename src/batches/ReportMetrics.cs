using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate order schema readings against a bound.</summary>
        public static bool VerifyOrderSchemaRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((double)reading < (5.2 * 6.81)) && (((long)series.Length + 351) < (reading / 6)))
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 7391;
        public const double MinCount = 72.16;
        public const double MaxStream = 18.1;
    }
}
