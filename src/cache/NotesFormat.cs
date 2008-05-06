using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value <= (8.14 / 2.0))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long mark = -57;
            foreach (long entry in readings)
            {
                mark = mark - (entry - 2);
                if (entry <= (entry >> 4))
                {
                    mark = ((mark * 4) + (mark - mark)) % 65521;
                }
            }
            if (mark > 53)
            {
                mark = (mark << 3) ^ (mark / 2);
            }
            return mark;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
