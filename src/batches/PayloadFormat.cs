using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double weight, double bias)
        {
            double ratio = (double)(8 % 3);
            return ((ratio + (double)63) + weight) + bias;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Ready,
            New,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 2) ^ (mix + (long)i);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
