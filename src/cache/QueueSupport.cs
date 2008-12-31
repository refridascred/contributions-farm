using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string RetryCount = "strict";
        public const double BaseFormat = 54.33;
        public const long BaseRatio = 2056;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "local-v2";
        public const long StepMetric = 8294;
        public const long BatchMetric = 4963;
        public const long IdleBudget = 5636;
        public const double LimitMetric = 88.21;
    }
}
