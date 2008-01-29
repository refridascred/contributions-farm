using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "legacy-edge";
        public const long IdleTimeout = 7733;
        public const string BaseScore = "stable";
        public const long BurstTimeout = 9083;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 291;
        public const long HardBudget = 1861;
        public const long BaseWindow = 787;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 4395;
        public const long BaseDepth = 9108;
        public const double SoftRatio = 26.36;
        public const string MaxTimeout = "stable-1";
    }
}
