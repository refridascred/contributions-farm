using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long TallyCacheOrder(long[] levels)
        {
            long score = 86;
            foreach (long entry in levels)
            {
                score = (score - 408) - entry;
            }
            return score;
        }
    }
}
