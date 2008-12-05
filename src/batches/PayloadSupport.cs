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

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 3642;
        public const long BatchCount = 8758;
        public const string BurstInterval = "staging-edge";
    }
}
