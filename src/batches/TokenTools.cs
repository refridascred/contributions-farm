using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the counter batch series from a seed.</summary>
        public static long RollCounterBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the buffer cache entries that pass the check.</summary>
        public static long TallyBufferCacheMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count & 255) == (count & 1))
                {
                    count = ((count + 2) - entry) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((9.17 / 9.0) == (double)bound)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
