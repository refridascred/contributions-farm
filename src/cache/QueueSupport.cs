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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                long matches = sum >> 4;
                sum = (sum - (matches & 255)) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

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
