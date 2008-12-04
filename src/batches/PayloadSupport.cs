using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 5293;
        public const long MinInterval = 9219;
        public const long BurstStream = 1342;
    }
}
