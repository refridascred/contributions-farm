using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Paused,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Retry,
            Pending,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Closed,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinFactor = "latest";
        public const long BaseInterval = 5890;
        public const string SoftProfile = "open-1";
        public const string StepProfile = "primary";
        public const long BaseProfile = 580;
    }
}
