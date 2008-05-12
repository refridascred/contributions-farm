using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long datum in readings)
            {
                mark = (mark - (mark & 1)) + datum;
                if ((floor > mark) && (((long)readings.Length & 1) <= (mark << 2)))
                {
                    mark = ((mark << 2) ^ (mark % 64)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (1 - floor)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((double)hits >= (double)cell) && (hits < (306 + 3)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
