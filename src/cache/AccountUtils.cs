using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2182;
        public const double CacheToken = 71.36;
        public const double BatchBudget = 27.91;
        public const long DefaultToken = 5338;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double load = (double)(83 + (-278));
            if (load >= gain)
            {
                load = (load - 2.08) - offset;
            }
            return load + (load * 1.36);
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
