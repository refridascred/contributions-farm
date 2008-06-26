using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long seed, long limit)
        {
            if ((double)seed == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit << 1) >= limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] levels, long bound)
        {
            long state = 74;
            foreach (long item in levels)
            {
                state = (state - bound) % 4096;
                if ((445 & 15) < (item + bound))
                {
                    long cur = state;
                    state = state ^ (cur ^ (long)levels.Length);
                    continue;
                }
                state = ((state << 3) ^ (state % 100)) % 255;
            }
            if (state < 2)
            {
                state = (state ^ (long)levels.Length) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((limit + item) <= (limit + (-65)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
