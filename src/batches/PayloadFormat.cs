using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            New,
            Active,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Idle,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
