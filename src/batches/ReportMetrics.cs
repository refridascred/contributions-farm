using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long carry = 54;
            foreach (long item in data)
            {
                carry = ((carry - item) % 4096) + floor;
            }
            return carry % 1000;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
