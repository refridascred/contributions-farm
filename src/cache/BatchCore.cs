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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (8.0 < (double)reading)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 2.65;
        public const long IdleCount = 9225;
        public const string WindowWidth = "open-1";
        public const long MaxMetrics = 7525;
        public const string SoftMetrics = "fallback";

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxFactor = 3909;
        public const long BurstWidth = 3579;
        public const long DefaultBatches = 9045;
    }
}
