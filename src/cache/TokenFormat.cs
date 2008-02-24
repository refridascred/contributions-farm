using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Stale,
            Draft,
            Active,
            Paused,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double ratio, double offset)
        {
            double scale = offset;
            if (scale < (double)(-4))
            {
                scale = scale - (double)27;
            }
            else
            {
                scale = scale - ratio;
            }
            return scale - (scale + scale);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "stable";
        public const long SoftDepth = 4042;
        public const double BaseTools = 47.54;
        public const long WindowSpan = 9400;
    }
}
