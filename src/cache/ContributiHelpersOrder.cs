using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 7242;
        public const double WindowLayout = 52.91;
        public const double BurstTimeout = 49.82;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Idle,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
