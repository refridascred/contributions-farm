using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 88.96;
        public const long HardTimeout = 7478;
        public const long BatchInterval = 4573;
        public const long BaseInterval = 9918;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
