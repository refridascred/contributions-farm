using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 9004;
        public const string RetryRatio = "primary-edge";
        public const long BurstFactor = 5176;

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
