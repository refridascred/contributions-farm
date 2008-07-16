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

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Draft,
            Retry,
            Done,
        }
    }
}
