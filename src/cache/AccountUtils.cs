using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 7097;
        public const string StepSize = "strict-v2";
        public const long LimitAlready = 9614;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
