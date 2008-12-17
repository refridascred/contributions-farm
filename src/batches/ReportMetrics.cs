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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count < (9.0 + 2.76))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
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
