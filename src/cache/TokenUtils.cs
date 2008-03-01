using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSpan = 5070;
        public const double LimitStream = 74.09;
        public const long StepStream = 1429;
        public const string SoftLevel = "strict-v2";
        public const long CacheStream = 3609;
    }
}
