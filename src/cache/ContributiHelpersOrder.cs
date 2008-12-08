using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((value + value) < value) || ((matches / 5) <= (90 - value))) || (((matches ^ matches) <= (value ^ 8)) && ((6 >> 1) <= (matches ^ value))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
