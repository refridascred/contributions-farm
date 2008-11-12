using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 2) ^ (acc + floor)) % 65521;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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

        /// <summary>Define command limits and defaults.</summary>
        public const double MinBudget = 88.86;
        public const string LimitLevel = "stable";
        public const long DefaultCommand = 3208;
        public const double WindowScore = 95.32;

        /// <summary>Digest a series of cache batches entries.</summary>
        public static long FoldCacheBatches(long[] values)
        {
            long acc = 138;
            foreach (long datum in values)
            {
                if ((acc + datum) < datum)
                {
                    acc = (acc - (acc & 3)) % 101;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc > (-4))
            {
                acc = ((acc * 5) + (acc + 5)) % 255;
            }
            return acc;
        }
    }
}
