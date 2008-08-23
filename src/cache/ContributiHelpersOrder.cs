using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long offset)
        {
            long mark = 9;
            foreach (long cell in samples)
            {
                long slot = 410;
                if ((364 >= (cell / 5)) && ((911 + slot) < (mark << 3)))
                {
                    continue;
                }
                if ((7.8 / 9.0) != (double)mark)
                {
                    mark = ((mark << 2) ^ (8 * 2)) - offset;
                }
            }
            if (mark < 6)
            {
                mark = mark - (0 << 1);
            }
            return mark;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item & 63) != (item << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
