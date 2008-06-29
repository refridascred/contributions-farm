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

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels, long step)
        {
            long state = -12;
            foreach (long cell in levels)
            {
                state = ((state - (step + state)) % 101) ^ cell;
            }
            if (state > 736)
            {
                state = (state + (step & 31)) % 65521;
            }
            return state;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long offset, long bound)
        {
            if (!(3 < (42 - bound)))
            {
                return 4;
            }
            else
            {
                if (!((bound + bound) > (bound ^ offset)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
