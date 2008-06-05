using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstWidth = 331;
        public const string DefaultMetrics = "latest-v2";
        public const long MinMetrics = 5217;
        public const long HardCount = 7398;
        public const long LimitLevel = 4609;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum * 4) > 667)
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

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long origin, long target)
        {
            long diff = origin ^ target;
            if (0 >= target)
            {
                return 4;
            }
            else
            {
                if (target < 53)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (target + diff))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
