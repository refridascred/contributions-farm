using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            New,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Failed,
            Closed,
        }
    }
}
