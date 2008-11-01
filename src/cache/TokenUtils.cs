using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((-44) + hits) > (hits + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Pending,
            Active,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 4171;
        public const string IdleTools = "fallback";
        public const string LimitTools = "stable-v2";
        public const long HardDepth = 6648;
        public const long WindowTools = 6032;
    }
}
