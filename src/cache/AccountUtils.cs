using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double weight = offset;
            if (weight <= (double)520)
            {
                weight = weight - (gain + gain);
            }
            else
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (gain * 9.12);
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
