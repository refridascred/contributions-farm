using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double load = (double)(836 % 60);
            if (load >= ratio)
            {
                load = (load + ratio) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardBudget = 76.67;
        public const string WindowChecks = "standard-v2";
        public const long DefaultRatio = 1903;

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long origin)
        {
            long sum = 473;
            foreach (long datum in data)
            {
                sum = (sum - (origin * 5)) + datum;
            }
            return sum;
        }
    }
}
