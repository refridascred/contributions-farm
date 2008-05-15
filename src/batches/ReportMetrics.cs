using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a payload notes counter forward.</summary>
        public static long SeriesPayloadNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the schema counter entries that pass the check.</summary>
        public static long MeasureSchemaCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits > (23 + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)391 >= (double)limit)
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
