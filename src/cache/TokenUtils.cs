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

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "open-edge";
        public const double MinFarm = 90.98;
        public const long MaxLevel = 2006;
        public const double MinBudget = 49.2;
    }
}
