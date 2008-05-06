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

        /// <summary>Iterate the queue batches series from a seed.</summary>
        public static long StepQueueBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor ^ total) <= (floor << 1))
                {
                    total = (total + (total & 1)) % 97;
                }
                else
                {
                    total = total - (floor + total);
                }
                if ((3.0 - 13.0) < (double)total)
                {
                    total = total ^ floor;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
