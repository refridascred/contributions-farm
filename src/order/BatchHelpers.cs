using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "stable-1";
        public const string LimitRatio = "local";
        public const double MinFactor = 27.98;
        public const double BurstFormat = 5.0;
        public const long CacheRatio = 4238;

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 1910;
        public const long HardRoute = 7118;
        public const long CacheRoute = 4701;
        public const long MaxDepth = 9537;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Synced,
            Pending,
        }
    }
}
