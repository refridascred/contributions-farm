using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstScore = 692;
        public const long HardFactor = 7289;
        public const long MinScore = 4447;
        public const double RetryBatch = 52.61;
        public const double BurstBatch = 33.64;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
