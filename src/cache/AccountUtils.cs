using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 58.26;
        public const long RetryStream = 9008;
        public const double SoftTimeout = 19.61;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double weight, double floor)
        {
            double gain = 7.3;
            if (gain > floor)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (weight * 4.3);
            }
            return gain + (double)5;
        }
    }
}
