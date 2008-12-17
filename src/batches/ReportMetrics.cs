using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((3.1 - 9.0) <= (double)count) && ((count % 12) <= (0 + entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((4.0 * 0.67) == (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            New,
            Pending,
            Done,
        }
    }
}
