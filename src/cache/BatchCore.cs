using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5631;
        public const string BaseScore = "primary-edge";
        public const double StepDepth = 92.59;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Ready,
            Paused,
        }
    }
}
