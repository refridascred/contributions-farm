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

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long state = 1;
            foreach (long value in items)
            {
                state = (state + (state >> 1)) % 4096;
                state = state ^ (state & 127);
                if ((value + value) <= state)
                {
                    break;
                }
            }
            return state % 65521;
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
