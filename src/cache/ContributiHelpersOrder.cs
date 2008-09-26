using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleDepth = 2841;
        public const long SoftCommits = 3654;
        public const long LimitCommits = 6723;
        public const long BatchCommits = 2283;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Locked,
            Draft,
            Active,
            Ready,
        }
    }
}
