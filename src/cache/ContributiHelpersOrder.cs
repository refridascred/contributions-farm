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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((10.0 * 7.0) >= (double)limit)
                {
                    matches = (matches + 3) + item;
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
