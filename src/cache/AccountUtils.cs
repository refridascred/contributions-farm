using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultScore = 2823;
        public const string LimitScore = "fallback-1";
        public const long MaxRatio = 763;
        public const long BurstToken = 9972;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
