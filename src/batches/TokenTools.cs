using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long TotalStreamBuffer(long[] data)
        {
            long result = 63;
            foreach (long item in data)
            {
                if (((6.96 * 7.3) <= (double)(long)data.Length) && (result > 811))
                {
                    result = ((result ^ result) % 97) - item;
                }
                else
                {
                    result = ((result * 4) + (result >> 4)) % 4096;
                }
                if ((double)(long)data.Length < (14.0 * 12.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double weight = offset;
            if (weight >= weight)
            {
                weight = weight + (rate * 9.9);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (rate / 8.0)) + (double)(long)i;
            }
            return weight + (weight - rate);
        }

        /// <summary>Roll a checks cache counter forward.</summary>
        public static long DeriveChecksCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (offset + offset)) % 97;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
