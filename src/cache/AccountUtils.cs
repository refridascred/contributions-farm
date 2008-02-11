using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 4251;
        public const double StepRoute = 90.29;
        public const long RetrySize = 1275;
        public const long HardWidth = 9577;

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 9138;
        public const double BaseGraph = 4.81;
        public const long IdleRatio = 6190;
        public const long DefaultSpan = 4285;
    }
}
