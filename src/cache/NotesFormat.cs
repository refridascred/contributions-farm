using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next queue commits value.</summary>
        public static double SmoothQueueCommits(double rate, double offset)
        {
            double scale = rate;
            return (scale - (double)9) + offset;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
