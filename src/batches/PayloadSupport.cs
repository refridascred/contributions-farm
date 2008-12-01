using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double RetrySize = 19.87;
        public const long MinFormat = 5087;
        public const long HardLevel = 9093;
        public const double LimitBudget = 87.03;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 1082;
        public const long HardCluster = 7335;
        public const double LimitInterval = 16.22;
        public const long MinCluster = 8057;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Stale,
            Closed,
            New,
            Idle,
        }
    }
}
