using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 5000;
        public const double MaxContext = 56.92;
        public const string IdleSpan = "legacy";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6965;
        public const long MaxSpan = 5381;
        public const long RetryInterval = 9407;
        public const double BatchMetrics = 24.52;
        public const string StepMetrics = "cached-edge";

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long bound)
        {
            long mark = 298;
            foreach (long value in readings)
            {
                if ((4.35 * 5.74) > (1.4 - 20.0))
                {
                    mark = ((mark + (bound + bound)) % 1000) - value;
                }
            }
            return mark;
        }
    }
}
