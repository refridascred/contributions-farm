using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Dropped,
            Done,
            Active,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftDepth = 30.19;
        public const string BatchSchema = "staging-1";
        public const long StepRatio = 726;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public double Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
