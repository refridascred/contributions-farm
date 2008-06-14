using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowTimeout = 5814;
        public const long StepCount = 9186;
        public const string RetrySize = "standard-v2";

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Retry,
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Token { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
