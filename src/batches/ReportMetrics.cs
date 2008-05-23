using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseTimeout = 4999;
        public const string BaseFormat = "legacy";
        public const double IdleFormat = 48.67;
        public const long RetrySpan = 5430;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 164;
        public const long CacheChecks = 3053;
        public const long DefaultFactor = 7963;
        public const long BaseDepth = 4614;
        public const long SoftChecks = 747;
    }
}
