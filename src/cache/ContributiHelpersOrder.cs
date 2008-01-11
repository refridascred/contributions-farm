using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a cache entry sample.</summary>
        public static long FindCacheEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
