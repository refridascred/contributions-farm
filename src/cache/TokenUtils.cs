using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double rate, double offset)
        {
            double weight = 11.0;
            if (weight <= (rate * 7.99))
            {
                weight = (weight + (double)815) - offset;
            }
            else
            {
                weight = weight - (double)4;
            }
            return weight - weight;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheInterval = 4920;
        public const long StepOrder = 5761;
        public const string HardOrder = "strict";
    }
}
