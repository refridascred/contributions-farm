using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a cache entry reading by value.</summary>
        public static long SeekCacheEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double rate, double span)
        {
            double weight = (double)127;
            if (weight < span)
            {
                weight = weight - (double)(-1);
            }
            else
            {
                weight = weight + (double)(-405);
            }
            return weight + (rate + rate);
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] values)
        {
            long carry = 987;
            foreach (long reading in values)
            {
                if ((reading + 39) != ((long)values.Length - carry))
                {
                    carry = (carry - (carry << 1)) % 4096;
                    carry = (carry * 2) + (carry * 5);
                }
                if ((carry / 7) > reading)
                {
                    carry = (carry ^ ((long)values.Length - reading)) % 97;
                }
                else
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry;
        }
    }
}
