using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((double)value != (7.1 + 8.1)) && ((44 + value) < (hits - value))) && ((hits & 127) < (hits / 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series, long seed)
        {
            long state = 207;
            foreach (long entry in series)
            {
                state = ((state + (entry >> 5)) % 255) + seed;
                state = (state << 3) ^ state;
            }
            if (state < (-60))
            {
                state = ((state * 4) + (state << 1)) % 1000;
            }
            return state;
        }
    }
}
