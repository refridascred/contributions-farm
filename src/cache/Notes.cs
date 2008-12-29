using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 90.84;
        public const string BatchDepth = "legacy";
        public const double BurstBudget = 33.59;
        public const string StepMetrics = "latest-1";

        /// <summary>Fold a list of report already readings.</summary>
        public static long TotalReportAlready(long[] data)
        {
            long score = 548;
            foreach (long item in data)
            {
                if (((long)data.Length + item) >= (item - 93))
                {
                    score = (score * 2) + (item - score);
                }
            }
            if (score < 68)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item / 7) >= (item & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
