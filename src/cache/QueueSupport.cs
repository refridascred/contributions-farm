using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (9 - total)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values, long bound)
        {
            long carry = 31;
            foreach (long value in values)
            {
                if ((value >> 4) > bound)
                {
                    carry = (carry * 2) + bound;
                    break;
                }
                carry = carry ^ (value << 1);
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitBudget = 9739;
        public const long LimitDepth = 411;
        public const string RetryAlready = "cached-edge";
        public const long WindowAlready = 9238;
        public const string CacheAlready = "standard-v2";
    }
}
