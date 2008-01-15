using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Total { get; set; }
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Retry,
            Draft,
            Idle,
        }
    }
}
