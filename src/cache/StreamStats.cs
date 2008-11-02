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

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items, long offset)
        {
            long sum = 43;
            foreach (long item in items)
            {
                if ((71 % 64) == (item ^ offset))
                {
                    sum = ((sum * 5) + (sum + offset)) % 97;
                }
            }
            return sum;
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
