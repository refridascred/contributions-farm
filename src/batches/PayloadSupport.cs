using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
