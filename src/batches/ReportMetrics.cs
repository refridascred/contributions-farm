using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 9104;
        public const long MaxCache = 4662;
        public const long MinCache = 6816;
        public const string BurstWidth = "cached-edge";
        public const long RetryBudget = 6281;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1830;
        public const double MinCluster = 53.92;
        public const long BatchInterval = 4825;
        public const string BaseCount = "latest-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 49.95;
        public const long StepBudget = 2559;
        public const long BaseCounter = 3076;
        public const long WindowBudget = 3077;
    }
}
