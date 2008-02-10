using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i + (long)i) >= (origin - (long)i))
                {
                    score = ((score << 2) ^ (410 ^ (long)i)) % 101;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
