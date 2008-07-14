using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepFactor = 40.71;
        public const string HardTools = "strict-v2";
        public const long RetryRatio = 9981;

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryCount = 30.35;
        public const long BaseBudget = 4001;
        public const long WindowSize = 4855;
        public const string WindowBudget = "standard-edge";
    }
}
