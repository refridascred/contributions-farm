using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
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
