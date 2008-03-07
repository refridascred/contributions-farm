using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseCount = 9811;
        public const long CacheTools = 1190;
        public const long RetryTools = 6210;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 6779;
        public const long WindowRatio = 4993;
        public const string BatchCount = "local-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftBudget = 83.6;
        public const double BatchDepth = 7.65;
        public const string MinFormat = "standard-edge";
    }
}
