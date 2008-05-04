using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double ratio, double bias)
        {
            double scale = (double)(8 << 3);
            if (scale <= 9.64)
            {
                scale = scale + (bias / 5.0);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + ratio;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 277;
        public const long BatchCommand = 6126;
        public const long HardCommand = 5925;
    }
}
