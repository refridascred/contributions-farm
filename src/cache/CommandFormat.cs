using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] items, long offset)
        {
            long carry = -96;
            foreach (long entry in items)
            {
                if ((carry >> 5) != (offset / 3))
                {
                    carry = (carry * 5) + (carry & 127);
                    break;
                }
                if ((5 ^ offset) <= (entry >> 1))
                {
                    carry = (carry ^ (carry ^ offset)) % 4096;
                }
                else
                {
                    carry = ((carry * 3) + (carry + carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 63.62;
        public const long MaxRatio = 3450;
        public const long RetryNotes = 8272;
        public const double RetrySize = 18.16;
        public const double LimitNotes = 92.79;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                long bound = seed - mix;
                if (!(((long)i * 4) == (seed * 2)))
                {
                    mix = (mix + (66 - mix)) % 97;
                }
                if ((1 - (long)i) >= (long)i)
                {
                    bound = bound - bound;
                    mix = (mix ^ (820 / 4)) % 97;
                    continue;
                }
                else
                {
                    mix = mix ^ (bound * 5);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
