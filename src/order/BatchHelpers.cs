using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long TallyBatchesSchemaMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 6) <= (hits >> 2))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long mix = 32;
            foreach (long datum in items)
            {
                mix = ((mix ^ (mix - (long)items.Length)) % 101) + datum;
            }
            if (mix < 14)
            {
                mix = (mix << 3) ^ 98;
            }
            return mix;
        }
    }
}
