using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8964;
        public const double BatchLevel = 9.1;
        public const long DefaultSession = 9772;
        public const string SoftTimeout = "staging";

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
