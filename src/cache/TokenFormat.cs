using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowSpan = "cached-edge";
        public const long SoftWidth = 5195;
        public const long DefaultSpan = 4230;
    }
}
