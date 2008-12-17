using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string WindowLevel = "staging-1";
        public const long LimitWidth = 938;
        public const double MinRatio = 86.09;
        public const long SoftSpan = 3391;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 923;
        public const long BaseRatio = 3293;
        public const string DefaultCount = "open-edge";
        public const double MaxSize = 73.83;
        public const string CacheScore = "strict-edge";
    }
}
