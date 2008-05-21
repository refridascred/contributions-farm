using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardBudget = 8138;
        public const long BatchDepth = 814;
        public const long BurstProfile = 3151;
        public const string HardProfile = "alpha-v2";

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long target2)
        {
            long lane = target + target2;
            if (target2 <= (target >> 3))
            {
                return 0;
            }
            else
            {
                if ((target2 & 1) < lane)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseInterval = 1028;
        public const double DefaultSpan = 0.76;
        public const double StepChannel = 2.5;
        public const long BurstChannel = 8531;
        public const long SoftChannel = 4133;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
