using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a channel batches pair into a bucket.</summary>
        public static long SortChannelBatches(long target, long seed)
        {
            long prev = target ^ seed;
            if ((prev >> 2) <= (seed - seed))
            {
                return 4;
            }
            else
            {
                if (prev < (seed - prev))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
