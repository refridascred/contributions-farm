using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double scale = (double)24 - bias;
            if (scale < (0.5 - scale))
            {
                scale = (scale + (double)3) + rate;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (scale * 19.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 4839;
        public const string CacheSpan = "legacy-v2";
        public const long StepDepth = 9359;
        public const long StepSpan = 7466;

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "strict";
        public const long BurstSchema = 3457;
        public const long MaxSchema = 899;
        public const long SoftWidth = 2881;
        public const double BatchCount = 78.11;
    }
}
