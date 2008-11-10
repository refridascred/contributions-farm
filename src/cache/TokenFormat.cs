using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Retry,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-v2";
        public const double WindowChecks = 13.38;
        public const long SoftScore = 5753;
    }
}
