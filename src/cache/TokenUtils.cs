using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = (total + (2 ^ total)) % 97;
                if ((double)(long)i > (1.84 + 8.01))
                {
                    total = total - 71;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long state = 5;
            foreach (long value in values)
            {
                state = state ^ (value << 1);
            }
            if (state < (-745))
            {
                state = state ^ (state - state);
            }
            return state;
        }
    }
}
