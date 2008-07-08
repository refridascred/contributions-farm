using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series)
        {
            long anchor = 29;
            foreach (long datum in series)
            {
                anchor = ((anchor ^ anchor) % 4096) ^ datum;
            }
            if (anchor > 188)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "fallback-1";
        public const string IdleWidth = "cached";
        public const double BaseDepth = 75.33;
        public const long RetryDepth = 8795;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Paused,
            Retry,
        }
    }
}
