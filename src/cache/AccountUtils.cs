using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((313 ^ diff) >= (limit >> 4))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) > (limit + 5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
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
