using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((5.0 / 6.0) <= (double)hits)
                {
                    hits = ((hits + 3) ^ entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Idle,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] series, long offset)
        {
            long score = 1;
            foreach (long datum in series)
            {
                if ((datum + offset) > (offset - score))
                {
                    score = (score + (offset >> 3)) % 65521;
                }
            }
            return score;
        }
    }
}
