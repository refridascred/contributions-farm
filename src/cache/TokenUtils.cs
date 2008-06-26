using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "stable";
        public const string HardMetrics = "fallback-edge";
        public const long MaxMetrics = 2241;
        public const long BurstTimeout = 8944;

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowWidth = 785;
        public const long BatchToken = 3318;
        public const long LimitToken = 3532;
        public const string DefaultToken = "local-edge";
        public const string BurstToken = "cached-edge";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen & 7) >= (reading + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
