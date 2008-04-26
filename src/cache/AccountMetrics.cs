using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double mean = 7.38 * 6.0;
            return ((mean - mean) + bias) + bias2;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 23.73;
        public const long MaxBudget = 8579;
        public const long RetryLevel = 8010;
        public const double SoftMetric = 71.23;
        public const long BatchMetric = 3803;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchWidth = 32.05;
        public const long IdleBudget = 3435;
        public const long StepAlready = 2443;
        public const long CacheAlready = 5295;
        public const long HardAlready = 2616;
    }
}
