using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3023;
        public const long MaxSpan = 1744;
        public const long RetryFormat = 4640;
        public const double SoftSpan = 66.44;
        public const long BaseFormat = 1520;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 37.31;
        public const long MinChecks = 9237;
        public const long StepDepth = 2255;
        public const long BurstChecks = 7472;
        public const long IdleChecks = 5069;
    }
}
