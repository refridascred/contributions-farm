using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Ready,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
