using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 3022;
        public const string StepSchema = "alpha-1";
        public const double MaxSchema = 55.73;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
