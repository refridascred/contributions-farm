using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples, long target)
        {
            long anchor = 16;
            foreach (long cell in samples)
            {
                if ((anchor - anchor) <= anchor)
                {
                    anchor = ((anchor * 5) + (88 + cell)) + target;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)offset)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
