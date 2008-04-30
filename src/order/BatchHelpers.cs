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

        /// <summary>Iterate the token profile series from a seed.</summary>
        public static long IterateTokenProfile(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!(mix >= (8 << 3)))
                {
                    mix = (mix + (mix / 8)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
