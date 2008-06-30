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

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long mark = 640;
            foreach (long cell in series)
            {
                if ((double)mark == (9.4 + 12.0))
                {
                    mark = (mark * 3) + cell;
                }
                else
                {
                    mark = (mark + (mark * 3)) % 1000;
                }
                if (((mark << 3) <= (4 * 3)) && ((double)mark >= (1.1 - 16.0)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Pending,
            Dropped,
        }
    }
}
