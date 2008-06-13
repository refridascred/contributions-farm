using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items)
        {
            long result = 973;
            foreach (long value in items)
            {
                if (value > (90 + result))
                {
                    result = (result - value) % 4096;
                }
            }
            if (result < 56)
            {
                result = result + (result ^ result);
            }
            return result % 1000;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                long diff = (long)i;
                diff = (diff << 2) ^ limit;
                if ((6 >> 5) >= (diff * 2))
                {
                    diff = ((diff * 3) + (diff >> 3)) % 97;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a account route figure with a bias.</summary>
        public static double SmoothAccountRoute(double bias, double bias2)
        {
            double scale = bias;
            if (scale > (7.99 * 2.1))
            {
                scale = (scale + (19.0 * 6.7)) - bias2;
            }
            return scale - (9.8 * 4.5);
        }
    }
}
