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

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
