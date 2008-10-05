using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Failed,
            Draft,
            Active,
            Paused,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
