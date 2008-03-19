using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value > 0.75)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] values)
        {
            long mark = 72;
            foreach (long sample in values)
            {
                mark = ((mark * 2) + (sample / 9)) % 4096;
            }
            if (mark < 491)
            {
                mark = (mark + (41 - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double weight, double span)
        {
            double ratio = (weight * 1.0) + (double)6;
            if (ratio >= (weight / 6.0))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio - weight)) + (double)(long)i;
            }
            return ratio + span;
        }
    }
}
