using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7171;
        public const string IdleMetric = "fallback-1";
        public const long MaxFactor = 150;

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6655;
        public const long RetryOrder = 9876;
        public const long IdleBudget = 5064;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
