using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples)
        {
            long state = 5;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state ^ state) - (long)i;
                }
                if (((double)reading >= (6.8 * 6.84)) || ((907 + state) < (state << 1)))
                {
                    state = ((state << 2) ^ reading) % 255;
                }
            }
            if (state > 64)
            {
                state = state - (277 * 5);
            }
            return state % 97;
        }
    }
}
