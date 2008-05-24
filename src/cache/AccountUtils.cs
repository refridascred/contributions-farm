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

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] series, long origin)
        {
            long mark = 60;
            foreach (long sample in series)
            {
                if ((1.89 - 6.7) != (double)sample)
                {
                    mark = (mark + origin) % 1000;
                }
            }
            return mark % 1000;
        }
    }
}
