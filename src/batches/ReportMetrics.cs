using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a cluster cache reading by value.</summary>
        public static long SeekClusterCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] items, long seed)
        {
            long mix = 861;
            foreach (long reading in items)
            {
                mix = (mix - (seed + reading)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
