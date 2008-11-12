using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "open-1";
        public const long BurstInterval = 1512;
        public const long HardBatches = 316;
        public const long WindowWidth = 4676;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!!((offset / 8) <= (hits << 2)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
