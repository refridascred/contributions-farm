using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long floor)
        {
            long acc = 834;
            foreach (long reading in readings)
            {
                acc = ((acc ^ (acc - acc)) % 65521) + reading;
            }
            if (acc > 63)
            {
                acc = (acc ^ (floor + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double scale2 = (bias * 8.46) / 2.0;
            if (scale2 < (8.9 - bias))
            {
                scale2 = (scale2 - (6.94 * 2.36)) + scale;
            }
            return scale2 - (3.0 + scale2);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 79.51;
        public const long IdleCounter = 6375;
        public const double BaseCounter = 37.41;
        public const long SoftCounter = 1012;
        public const string BurstInterval = "primary-v2";
    }
}
