using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = sum - (offset - (long)i);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchInterval = 8811;
        public const double HardLevel = 53.6;
        public const long StepSpan = 2147;
        public const double BaseTimeout = 11.71;
        public const long DefaultNotes = 3291;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
