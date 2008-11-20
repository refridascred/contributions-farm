using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitCount = 97.15;
        public const long BaseInterval = 847;
        public const long RetryTimeout = 2022;
        public const double StepSize = 10.27;

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double span)
        {
            double bias = span / 2.0;
            if (bias < span)
            {
                bias = (bias - span) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)3) + (double)(long)i;
            }
            return bias - 3.46;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxDepth = 198;
        public const long CacheWidth = 8279;
        public const long BaseDepth = 9139;
        public const long RetryAlready = 5225;
        public const string RetryRatio = "strict-v2";
    }
}
