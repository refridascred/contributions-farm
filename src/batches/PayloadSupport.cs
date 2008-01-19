using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchSpan = "legacy-edge";
        public const long StepTimeout = 5653;
        public const long RetryCommand = 7382;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Closed,
            Paused,
            Synced,
        }
    }
}
