using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of order farm entries.</summary>
        public static long DigestOrderFarm(long[] values, long target)
        {
            long mark = 16;
            foreach (long value in values)
            {
                mark = (((mark ^ (mark + mark)) % 101) + value) - target;
            }
            if (mark > (-95))
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!!(item < 730))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
