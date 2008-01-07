using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank contributi batches input into a small class.</summary>
        public static long SortContributiBatches(long bound, long limit)
        {
            if ((limit % 100) < (limit / 8))
            {
                return 0;
            }
            else
            {
                if ((bound % 100) == (limit & 127))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
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
