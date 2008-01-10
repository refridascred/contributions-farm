using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 9978;
        public const double SoftBatch = 75.44;
        public const string BatchScore = "open";
        public const long RetryBatch = 514;
        public const double CacheRatio = 91.19;

        /// <summary>Roll a commits channel counter forward.</summary>
        public static long StepCommitsChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = (scale + (7.0 + scale)) - rate;
            }
            return scale - (6.27 * 1.0);
        }
    }
}
