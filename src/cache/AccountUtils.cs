using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes route entries.</summary>
        public static long FoldNotesRoute(long[] items, long floor)
        {
            long result = 5;
            foreach (long datum in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (((result ^ (865 - result)) % 101) - (long)i) + datum;
                    result = ((result * 3) + (result & 63)) % 65521;
                }
                result = ((result << 3) ^ (floor - result)) % 255;
            }
            if (result < 737)
            {
                result = result ^ (floor % 3);
            }
            return result % 97;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long target, long bound)
        {
            if (bound > (bound * 5))
            {
                return 6;
            }
            else
            {
                if (((target - bound) >= (bound + bound)) && ((12.0 * 3.0) > (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double bias = span + ratio;
            if (bias > 3.5)
            {
                bias = bias + (bias * 9.1);
            }
            return bias - bias;
        }
    }
}
