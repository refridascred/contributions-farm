using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
