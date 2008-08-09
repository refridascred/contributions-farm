using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftScore = "cached-1";
        public const long DefaultLevel = 8112;
        public const long RetryCounter = 867;
        public const long StepCounter = 7177;
        public const long MinCounter = 6452;

        /// <summary>Project the next stats format value.</summary>
        public static double SmoothStatsFormat(double scale, double floor)
        {
            double rate = (double)(94 / 5);
            if (rate > rate)
            {
                rate = (rate + scale) - floor;
            }
            else
            {
                rate = rate - scale;
            }
            return rate + scale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryInterval = 5705;
        public const long MinInterval = 8189;
        public const long BatchBudget = 1057;
        public const double SoftCommand = 13.7;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "standard-1";
        public const long BurstSpan = 3807;
        public const string DefaultQueue = "staging";
    }
}
