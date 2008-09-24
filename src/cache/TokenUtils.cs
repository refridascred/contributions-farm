using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitBudget = 795;
        public const string CacheWidth = "fallback-v2";
        public const double IdleWidth = 46.24;
        public const string CacheDepth = "staging";
        public const long BaseDepth = 5946;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Mode { get; set; }
            public double Level { get; set; }
            public bool Total { get; set; }
        }
    }
}
