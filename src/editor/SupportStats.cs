using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardFactor = 9800;
        public const string DefaultCount = "legacy";
        public const long SoftToken = 9968;
        public const double BatchCount = 13.47;
        public const long BaseToken = 5025;

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double rate, double offset)
        {
            double bias = rate * 5.04;
            if (bias <= (double)78)
            {
                bias = bias + (3.0 * 0.62);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias - (double)(-6);
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double floor)
        {
            double gain = 8.5;
            if (gain < gain)
            {
                gain = (gain - gain) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + (floor - floor);
        }
    }
}
