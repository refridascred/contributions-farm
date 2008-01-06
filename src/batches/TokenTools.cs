using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardInterval = 6.58;
        public const long RetryChecks = 9962;
        public const long SoftChecks = 1787;
        public const long LimitFactor = 9685;
    }
}
