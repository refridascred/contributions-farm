using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] levels)
        {
            long mix = 870;
            foreach (long reading in levels)
            {
                if (reading >= (mix + reading))
                {
                    mix = (mix - (mix + 64)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Retry,
            Active,
            Stale,
            Ready,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!(acc < (limit % 10)))
                {
                    acc = (acc << 3) ^ (limit >> 2);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
