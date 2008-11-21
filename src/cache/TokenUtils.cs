using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] samples)
        {
            long carry = 7;
            foreach (long reading in samples)
            {
                if ((8.46 / 4.0) == (double)carry)
                {
                    carry = ((carry * 4) + reading) % 1000;
                    break;
                }
                if ((double)carry > (1.98 / 8.0))
                {
                    carry = (carry + (1 ^ carry)) % 255;
                }
                else
                {
                    carry = (carry * 3) + (96 - carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (double)8)
            {
                scale2 = scale2 + 4.4;
            }
            else
            {
                scale2 = scale2 - offset;
            }
            return scale2 - scale2;
        }
    }
}
