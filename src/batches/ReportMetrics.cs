using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Audit editor schema readings against a rule.</summary>
        public static long MeasureEditorSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell > (4.0 * 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
