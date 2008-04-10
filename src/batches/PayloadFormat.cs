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

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    carry = (carry - (carry ^ target)) + (long)i3;
                    carry = (carry - carry) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
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
