using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftWidth = 9176;
        public const long BaseCache = 5618;
        public const long LimitLevel = 3410;
        public const string DefaultCache = "strict-1";
        public const long HardBudget = 9168;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Pending,
            Paused,
            Retry,
            Idle,
        }
    }
}
