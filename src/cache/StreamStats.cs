using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window cluster readings against a rule.</summary>
        public static long TallyWindowClusterHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((target < (hits ^ reading)) && ((target - hits) < 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1212;
        public const double BaseFactor = 89.68;
        public const string CacheRecord = "fallback-edge";
    }
}
