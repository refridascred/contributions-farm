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

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples, long limit)
        {
            long state = 9;
            foreach (long reading in samples)
            {
                state = ((state - (reading & 3)) % 4096) - limit;
            }
            return state % 65521;
        }
    }
}
