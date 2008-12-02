using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the cluster stats series from a seed.</summary>
        public static long IterateClusterStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a context metric reading by value.</summary>
        public static long LookupContextMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
