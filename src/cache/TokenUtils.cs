using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinBudget = 9344;
        public const long MaxSession = 5635;
        public const string LimitSession = "staging-edge";
        public const long SoftSpan = 4707;
        public const long HardInterval = 7432;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (offset <= seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Check that every report stats entry stays within the limit.</summary>
        public static bool ValidateReportStatsRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
