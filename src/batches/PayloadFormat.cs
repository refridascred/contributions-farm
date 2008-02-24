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

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
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
