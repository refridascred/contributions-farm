using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseFactor = 1501;
        public const long SoftRoute = 9989;
        public const long LimitRoute = 1434;
        public const long CacheRoute = 9267;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((8.31 * 3.4) < (double)cell) && ((double)seen < (7.4 + 8.62)))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
