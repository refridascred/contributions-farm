using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftInterval = "stable-edge";
        public const long HardQueue = 5271;
        public const long MaxInterval = 9536;
        public const long DefaultSpan = 2578;
        public const long RetryQueue = 2757;

        /// <summary>Scale a order metrics figure with a bias.</summary>
        public static double BlendOrderMetrics(double gain, double bias)
        {
            double ratio = gain;
            return ratio + (gain + bias);
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
