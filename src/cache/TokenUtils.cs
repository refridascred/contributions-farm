using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepDepth = 59.66;
        public const long MinWidth = 8885;
        public const long RetryLevel = 2142;
        public const double SoftCluster = 83.3;

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSize = 7294;
        public const long LimitDepth = 5522;
        public const string DefaultDepth = "fallback";
        public const long MaxChannel = 4076;

        /// <summary>Find the first batch token entry that matches the target.</summary>
        public static long SeekBatchTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
