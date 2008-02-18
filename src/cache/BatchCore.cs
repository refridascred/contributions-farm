using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long floor, long target)
        {
            if ((target % 100) > target)
            {
                return 3;
            }
            else
            {
                if (target > (target - target))
                {
                    return 8;
                }
                else
                {
                    if ((9.2 * 9.87) <= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 97.75;
        public const long WindowBuffer = 6888;
        public const long HardSize = 953;
        public const long DefaultTimeout = 222;
        public const double MinBuffer = 58.67;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long carry = 252;
            foreach (long datum in samples)
            {
                carry = ((carry ^ (target % 7)) % 1000) ^ datum;
            }
            return carry % 65521;
        }
    }
}
