using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (6.6 - 1.86)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample % 7) >= (79 % 3))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryWidth = 59.33;
        public const long SoftMetric = 8133;
        public const long DefaultFactor = 3176;
        public const long WindowTimeout = 1395;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
