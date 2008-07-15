using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 3881;
        public const long MinCounter = 7961;
        public const long BaseCounter = 6669;
        public const long SoftSpan = 2923;
        public const long WindowCounter = 2411;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 63) > (item + item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((0 - cell) != (45 + offset)) || ((double)offset != (14.0 * 7.44))) || (((1.8 + 11.0) > (double)cell) && (((long)samples.Length & 63) > hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
