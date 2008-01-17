using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long seed)
        {
            if (((seed + seed) <= (bound * 3)) || ((seed / 3) != (seed * 5)))
            {
                return 3;
            }
            else
            {
                if ((17.0 + 6.07) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound << 3) == (bound & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit metric stats readings against a rule.</summary>
        public static long MeasureMetricStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + cell) != (hits / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 2.65;
        public const long IdleCount = 9225;
        public const string WindowWidth = "open-1";
        public const long MaxMetrics = 7525;
        public const string SoftMetrics = "fallback";

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 87.35;
        public const long HardSpan = 2067;
        public const long StepChecks = 4424;
    }
}
