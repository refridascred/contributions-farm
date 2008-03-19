using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 3866;
        public const long HardLevel = 3072;
        public const long LimitScore = 6384;
        public const string StepSize = "alpha";

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            New,
            Closed,
        }
    }
}
