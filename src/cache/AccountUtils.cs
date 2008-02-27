using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((5.18 * 3.2) != (double)target)
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long state = 78;
            foreach (long cell in levels)
            {
                state = ((state * 3) + (state % 16)) + cell;
                state = (state << 3) ^ (limit + state);
            }
            return state;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((target + target) >= 96)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
