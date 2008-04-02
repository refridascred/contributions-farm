using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long floor, long floor2)
        {
            long edge = floor + floor2;
            if ((floor < (edge << 3)) && ((2.9 * 14.0) == (double)edge))
            {
                return 2;
            }
            else
            {
                if (((edge + edge) <= edge) || (9 < (floor * 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

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
