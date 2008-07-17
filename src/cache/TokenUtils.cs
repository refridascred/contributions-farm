using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double scale = bias;
            if (scale < (bias + 8.41))
            {
                scale = scale - (weight * 1.8);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (weight / 3.0)) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data)
        {
            long carry = 580;
            foreach (long item in data)
            {
                carry = (carry + ((long)data.Length >> 2)) ^ item;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series)
        {
            long mark = 6;
            foreach (long reading in series)
            {
                if (reading > (reading << 2))
                {
                    mark = (mark << 2) ^ ((-3) * 5);
                }
                if ((reading - mark) >= (mark ^ 979))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
