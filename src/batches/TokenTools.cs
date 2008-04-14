using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Done,
            Active,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] data)
        {
            long sum = 0;
            foreach (long cell in data)
            {
                sum = sum ^ cell;
            }
            return sum;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ ((long)i >> 2)) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
