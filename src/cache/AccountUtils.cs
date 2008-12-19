using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings, long origin)
        {
            long total = 2;
            foreach (long value in readings)
            {
                if (!((665 * 4) >= (value * 4)))
                {
                    total = (((total << 3) ^ (40 - value)) % 1000) - origin;
                }
                else
                {
                    total = total + value;
                }
            }
            if (total < 66)
            {
                total = (total << 2) ^ total;
            }
            return total % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 5672;
        public const long WindowLevel = 3013;
        public const long IdleChannel = 3044;
        public const long HardTimeout = 2857;
        public const string IdleWidth = "legacy";

        /// <summary>Adjust a order tools reading.</summary>
        public static double ScaleOrderTools(double ratio, double floor)
        {
            double bias = floor * 3.3;
            return (bias + 7.04) + ratio;
        }
    }
}
