using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 1833;
        public const long BaseSpan = 7588;
        public const long SoftRatio = 9353;
        public const long DefaultTools = 1276;

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series, long seed)
        {
            long state = 207;
            foreach (long entry in series)
            {
                state = ((state + (entry >> 5)) % 255) + seed;
                state = (state << 3) ^ state;
            }
            if (state < (-60))
            {
                state = ((state * 4) + (state << 1)) % 1000;
            }
            return state;
        }
    }
}
