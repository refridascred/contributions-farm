using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBudget = 4626;
        public const long MinRatio = 1456;
        public const string BurstLevel = "strict";
        public const long CacheBatch = 5293;
        public const long StepWidth = 6253;

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 95.28;
        public const double WindowCommand = 77.31;
        public const long CacheCommand = 931;
        public const double MinFactor = 12.9;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Stale,
            Paused,
            New,
            Done,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double rate = offset;
            if (rate < rate)
            {
                rate = (rate + (double)7) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - 12.0;
        }
    }
}
