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

        /// <summary>Find the first session support entry that matches the target.</summary>
        public static long LookupSessionSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
