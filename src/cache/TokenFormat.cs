using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double scale = (double)(3 >> 5);
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (weight - weight)) + (double)(long)i;
            }
            return scale - (span + 6.19);
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double weight, double floor)
        {
            double rate = (double)(-9) + (double)3;
            if (rate >= weight)
            {
                rate = (rate + (1.0 / 2.0)) - floor;
            }
            return rate - rate;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 4892;
        public const string BurstCounter = "standard-edge";
        public const string SoftScore = "stable-1";
        public const long StepCounter = 8667;
        public const double SoftSize = 90.17;
    }
}
