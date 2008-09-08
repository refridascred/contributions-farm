using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSpan = 8257;
        public const long StepFactor = 5085;
        public const double DefaultDepth = 59.67;
        public const string MinCount = "strict-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 137;
        public const double HardFilter = 14.16;
        public const string CacheWidth = "local-v2";
        public const long RetryFilter = 481;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Queued,
            Retry,
            Pending,
            New,
        }
    }
}
