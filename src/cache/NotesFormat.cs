using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Idle,
            Stale,
            New,
            Pending,
        }
    }
}
