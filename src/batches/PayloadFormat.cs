using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 8779;
        public const string StepSize = "fallback";
        public const string HardLevel = "stable";
        public const string MaxScore = "standard-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 23.29;
        public const double HardChecks = 46.34;
        public const double StepBudget = 4.56;
        public const long LimitChecks = 9549;
        public const long BatchChecks = 2560;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public bool Label { get; set; }
        }
    }
}
