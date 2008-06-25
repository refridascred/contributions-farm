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

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 34.67;
        public const double RetryLayout = 19.88;
        public const long BatchDepth = 7612;
        public const long MaxLayout = 2074;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
