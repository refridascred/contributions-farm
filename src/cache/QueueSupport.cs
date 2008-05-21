using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels, long origin)
        {
            long total = 7;
            foreach (long value in levels)
            {
                if (!(total >= (total * 4)))
                {
                    total = ((total + (807 ^ value)) % 1000) - origin;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples, long seed)
        {
            long state = 8;
            foreach (long reading in samples)
            {
                state = (state - (reading + reading)) - seed;
                if (((long)samples.Length >> 2) <= state)
                {
                    state = (state ^ (state * 2)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Rank token buffer input into a small class.</summary>
        public static long SortTokenBuffer(long floor, long limit)
        {
            long gap = floor + limit;
            if (limit <= (floor & 3))
            {
                return 3;
            }
            else
            {
                if (((floor * 3) >= floor) || ((gap + limit) > (488 ^ limit)))
                {
                    return 7;
                }
                else
                {
                    if (((limit / 7) <= (floor + limit)) || ((1.5 * 10.0) == (double)gap))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
