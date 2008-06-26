using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double scale, double bias)
        {
            double gain = 5.0;
            return ((gain - 0.59) + scale) + bias;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultTimeout = 6752;
        public const string StepStream = "primary-v2";
        public const long RetryStream = 4531;

        /// <summary>Audit account cache readings against a rule.</summary>
        public static long CountAccountCacheOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item > 2) || ((item ^ item) >= (count << 2)))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 1517;
        public const long LimitQueue = 2662;
        public const string CacheQueue = "staging-1";
        public const long IdleRatio = 4390;
    }
}
