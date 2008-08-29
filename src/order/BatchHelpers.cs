using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 68.52;
        public const long LimitDepth = 9456;
        public const long RetryInterval = 598;
        public const long MinCount = 3525;
    }
}
