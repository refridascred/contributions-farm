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

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Retry,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 32.25;
        public const long CacheRecord = 1733;
        public const double LimitRecord = 41.89;
    }
}
