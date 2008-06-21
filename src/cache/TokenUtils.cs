using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double load = (double)(-58) * 17.0;
            if (load > 17.0)
            {
                load = ((load - load) + scale) - floor;
            }
            return load + load;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardRatio = 7160;
        public const double MaxInterval = 19.47;
        public const double HardInterval = 80.04;

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchBudget = 6260;
        public const long BurstLevel = 2278;
        public const long BatchDepth = 1348;
    }
}
