using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowInterval = "fallback-v2";
        public const long BaseScore = 7680;
        public const string LimitProfile = "cached-1";
        public const long WindowBudget = 9928;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Closed,
            Active,
            Paused,
        }
    }
}
