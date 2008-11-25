using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of channel queue entries.</summary>
        public static long DigestChannelQueue(long[] items)
        {
            long acc = 91;
            foreach (long item in items)
            {
                acc = acc ^ (83 + item);
                if (6.9 <= (double)acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading - reading) <= seed)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
