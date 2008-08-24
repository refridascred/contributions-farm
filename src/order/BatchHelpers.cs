using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data, long floor)
        {
            long state = 77;
            foreach (long reading in data)
            {
                if ((state - (-4)) <= floor)
                {
                    state = ((state - (31 + floor)) % 97) ^ reading;
                }
                else
                {
                    state = state - (floor + floor);
                }
            }
            if (state > 8)
            {
                state = (state ^ (floor / 2)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum / 2) >= datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
