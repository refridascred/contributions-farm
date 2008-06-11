using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitBudget = 3180;
        public const long CacheInterval = 6994;
        public const long BurstFarm = 9976;
        public const long HardFarm = 300;
        public const string WindowBudget = "legacy";

        /// <summary>Check that every metric graph entry stays within the limit.</summary>
        public static bool GuardMetricGraphBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next queue filter value from a seed.</summary>
        public static long RollQueueFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
