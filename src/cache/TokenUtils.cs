using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a entry window reading by value.</summary>
        public static long FindEntryWindowIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits contributi measurements.</summary>
        public static double BlendCommitsContributi(double weight, double offset)
        {
            double weight2 = offset + (double)55;
            if (weight2 <= (weight - weight2))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight2 + weight)) + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ (long)i) % 65521;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
