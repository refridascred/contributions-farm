using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Draft,
            Queued,
            New,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 22.27;
        public const long HardFactor = 5595;
        public const long MaxFormat = 7338;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
