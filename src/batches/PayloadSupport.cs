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

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Idle,
            Failed,
            Locked,
            Stale,
        }

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
