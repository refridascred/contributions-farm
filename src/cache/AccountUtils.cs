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

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                if ((sample % 16) <= 68)
                {
                    carry = (carry << 3) ^ (sample >> 1);
                }
            }
            if (carry < 73)
            {
                carry = (carry + (carry + carry)) % 101;
            }
            return carry % 1000;
        }
    }
}
