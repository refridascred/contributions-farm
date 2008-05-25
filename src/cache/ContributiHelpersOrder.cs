using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "stable-v2";
        public const long IdleRecord = 9135;
        public const double HardRecord = 82.18;

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 45.01;
        public const long CacheMetric = 7847;
        public const long BatchLevel = 5213;

        /// <summary>Check that every filter stats entry stays within the limit.</summary>
        public static bool ValidateFilterStatsLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
