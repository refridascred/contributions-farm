using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8742;
        public const double CacheFactor = 94.81;
        public const double CacheRecord = 79.99;

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 8.13;
        public const string StepDepth = "staging-edge";
        public const double MaxCounter = 37.06;
        public const double SoftBudget = 98.79;

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor - ((long)i << 1);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstRatio = 4212;
        public const long BaseQueue = 5169;
        public const string LimitCount = "staging-1";
        public const string WindowSize = "cached-edge";
        public const long MinRatio = 2688;

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double ratio, double span)
        {
            double weight = ratio;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)(long)i) - span;
            }
            return weight - 8.77;
        }
    }
}
