using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long floor, long origin)
        {
            if ((double)floor >= 6.08)
            {
                return 2;
            }
            else
            {
                if ((double)origin != (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor == (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph commits entries.</summary>
        public static long TotalGraphCommits(long[] levels, long seed)
        {
            long score = -59;
            foreach (long sample in levels)
            {
                score = ((score * 5) + (score & 255)) % 4096;
                if (!(sample <= (42 - seed)))
                {
                    score = (score << 2) ^ (score - 93);
                }
            }
            if (score < 676)
            {
                score = score + (seed ^ score);
            }
            return score;
        }

        /// <summary>Check that every buffer entry entry stays within the limit.</summary>
        public static bool ValidateBufferEntryRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
