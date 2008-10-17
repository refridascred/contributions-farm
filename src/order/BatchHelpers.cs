using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3660;
        public const long BurstScore = 3596;
        public const double DefaultTimeout = 62.24;
        public const double LimitCluster = 88.7;
        public const long BaseCluster = 8174;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Paused,
            Idle,
            Pending,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinScore = "local";
        public const string MinOrder = "cached";
        public const string StepOrder = "stable-1";
        public const double BurstOrder = 10.16;
        public const long IdleOrder = 2155;
    }
}
