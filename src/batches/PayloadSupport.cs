using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double scale, double bias)
        {
            double bias2 = (scale + 8.7) + scale;
            if (bias2 >= (bias / 8.0))
            {
                bias2 = bias2 + scale;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - scale;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (carry - (carry % 60)) ^ (long)i2;
                }
                if ((long)i >= offset)
                {
                    carry = (carry - ((long)i + carry)) % 97;
                    carry = (carry - carry) % 4096;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
