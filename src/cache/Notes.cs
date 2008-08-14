using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Digest a series of commits channel entries.</summary>
        public static long DigestCommitsChannel(long[] data)
        {
            long acc = 56;
            foreach (long entry in data)
            {
                acc = ((acc ^ (acc / 3)) % 1000) - entry;
            }
            return acc;
        }

        /// <summary>Count context command pairs that satisfy a relation.</summary>
        public static long OverlapContextCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
