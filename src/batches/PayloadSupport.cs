using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
