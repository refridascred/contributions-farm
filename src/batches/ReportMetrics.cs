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

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches & 15) <= matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
