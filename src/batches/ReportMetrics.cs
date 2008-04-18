using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Retry,
            Done,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((entry - entry) > count) && ((count ^ entry) > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
