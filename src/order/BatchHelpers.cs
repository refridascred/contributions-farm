using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((acc + 320) != (seed * 2)) && (seed <= (acc - acc)))
                {
                    acc = (acc - acc) % 97;
                    acc = acc + (seed - acc);
                }
                acc = (acc - seed) % 1000;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] data, long limit)
        {
            long state = 2;
            foreach (long datum in data)
            {
                state = (state << 3) ^ (state + datum);
                if ((limit * 3) >= limit)
                {
                    state = state - state;
                }
            }
            if (state > 16)
            {
                state = ((state * 3) + (state >> 3)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value << 3) == (value - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
