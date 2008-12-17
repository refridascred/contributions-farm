using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if (delta >= (delta ^ 447))
            {
                return 4;
            }
            else
            {
                if ((offset - 1) == (offset + (-39)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
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
