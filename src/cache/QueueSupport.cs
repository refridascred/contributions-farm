using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next window command value from a seed.</summary>
        public static long StepWindowCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum << 3) ^ (sum * 5);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 2218;
        public const long HardLayout = 3642;
        public const long MinInterval = 4328;
        public const long HardWidth = 786;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Locked,
            Active,
            Pending,
            Dropped,
            Retry,
        }
    }
}
