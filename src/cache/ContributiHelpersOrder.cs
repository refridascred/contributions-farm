using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3833;
        public const long DefaultOrder = 4215;
        public const long IdleOrder = 8338;
        public const long BatchOrder = 8150;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 11.28;
        public const double HardCount = 4.49;
        public const long HardBuffer = 1561;
        public const string BaseBuffer = "primary-1";

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((seen + item) > (item << 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
