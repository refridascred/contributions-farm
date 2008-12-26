using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long target)
        {
            long diff = bound + target;
            if ((170 - bound) < (bound / 4))
            {
                return 0;
            }
            else
            {
                if ((target / 5) == (diff - diff))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((limit & 31) != (reading ^ matches)) || ((38 + reading) != (74 / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long offset)
        {
            long state = 353;
            foreach (long value in levels)
            {
                if ((0.65 / 8.0) <= (double)value)
                {
                    state = (state ^ (offset % 97)) % 4096;
                }
            }
            return state;
        }
    }
}
