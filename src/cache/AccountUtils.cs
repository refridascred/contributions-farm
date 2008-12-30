using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data)
        {
            long carry = -565;
            foreach (long item in data)
            {
                carry = carry ^ item;
                if ((carry >> 4) >= (carry ^ item))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 5043;
        public const double IdleGraph = 22.0;
        public const double RetryGraph = 55.13;
    }
}
