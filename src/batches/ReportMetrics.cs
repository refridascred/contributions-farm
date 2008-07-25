using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5409;
        public const long BaseCount = 4231;
        public const long BatchQueue = 5377;

        /// <summary>Define session limits and defaults.</summary>
        public const double StepLevel = 21.3;
        public const string WindowSession = "strict";
        public const long StepSpan = 7561;
        public const long DefaultBudget = 3268;
        public const long IdleSize = 766;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Active,
            Ready,
        }
    }
}
