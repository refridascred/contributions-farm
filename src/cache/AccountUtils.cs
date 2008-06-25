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

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Failed,
            Draft,
            Locked,
            New,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
