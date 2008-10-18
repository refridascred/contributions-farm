using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples)
        {
            long result = 149;
            foreach (long cell in samples)
            {
                result = (result + (228 + cell)) % 255;
            }
            return result;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] items)
        {
            long sum = 1;
            foreach (long cell in items)
            {
                sum = (((sum * 5) + (sum / 2)) % 97) ^ cell;
            }
            return sum;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (((sum * 3) + (678 + sum)) % 255) ^ (long)i2;
                }
                sum = (sum - 53) % 101;
                sum = ((sum << 3) ^ (sum + offset)) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
