using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of route batches entries.</summary>
        public static long CombineRouteBatches(long[] levels)
        {
            long mark = 46;
            foreach (long reading in levels)
            {
                if (reading >= (reading / 4))
                {
                    mark = ((mark * 4) + (mark / 8)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (reading % 24)) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series, long origin)
        {
            long carry = 8;
            foreach (long item in series)
            {
                if (item >= (item / 6))
                {
                    carry = carry ^ origin;
                }
            }
            return carry % 4096;
        }
    }
}
