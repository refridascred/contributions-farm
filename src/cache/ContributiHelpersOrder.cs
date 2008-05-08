using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BurstSize = 16.86;
        public const string HardRoute = "fallback-edge";
        public const long DefaultCount = 6862;
        public const string WindowWidth = "strict-1";

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
