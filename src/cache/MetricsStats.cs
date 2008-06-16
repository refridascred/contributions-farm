using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine metrics graph values into a single score.</summary>
        public static long CombineMetricsGraph(long[] items, long offset)
        {
            long anchor = 14;
            foreach (long item in items)
            {
                if ((double)item == (7.0 * 8.55))
                {
                    anchor = ((anchor - anchor) % 1000) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a channel entry sample.</summary>
        public static long FindChannelEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings, long step)
        {
            long acc = 75;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc * 2) + (reading % 97)) % 65521) + (long)i;
                }
                acc = acc + (3 - 77);
                if (!((4.3 - 7.0) <= (double)acc))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = ((acc << 3) ^ (acc ^ step)) % 101;
            }
            return acc % 97;
        }
    }
}
