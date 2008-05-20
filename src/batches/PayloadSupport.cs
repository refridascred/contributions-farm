using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitDepth = "primary-v2";
        public const double HardDepth = 36.59;
        public const long RetryScore = 2709;
        public const long StepContext = 8999;

        /// <summary>Blend two batch cache measurements.</summary>
        public static double ScaleBatchCache(double ratio, double offset)
        {
            double scale = ratio;
            if (scale <= (5.86 - ratio))
            {
                scale = (scale + (6.7 * 3.0)) + offset;
            }
            return scale - 3.0;
        }
    }
}
