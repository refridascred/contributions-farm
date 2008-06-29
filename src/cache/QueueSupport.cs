using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long state = 4;
            foreach (long item in series)
            {
                if ((19 << 2) >= state)
                {
                    state = (state + (5 * 2)) - item;
                }
            }
            return state;
        }

        /// <summary>Measure how many checks window samples are out of range.</summary>
        public static long AuditChecksWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally << 3) < 0))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the context session entries that pass the check.</summary>
        public static long MeasureContextSessionGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count <= (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
