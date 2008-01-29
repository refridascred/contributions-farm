using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
