using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 3673;
        public const long StepFarm = 321;
        public const string CacheRatio = "fallback";

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 1554;
        public const double IdleStats = 19.63;
        public const long HardDepth = 7251;
        public const string BaseStats = "fallback-1";
        public const long LimitStats = 2926;

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long MeasureMetricChannelOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)limit < 4.0) && (count <= sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
