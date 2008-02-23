using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSize = 4230;
        public const double IdleFactor = 7.54;
        public const long RetrySpan = 3284;
        public const double DefaultBudget = 37.81;
        public const string CacheCount = "local-edge";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Locked,
            Ready,
        }
    }
}
