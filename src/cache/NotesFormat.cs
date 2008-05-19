using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 245;
        public const long MaxScore = 1125;
        public const long WindowAccount = 6175;
        public const long MinLevel = 5669;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
