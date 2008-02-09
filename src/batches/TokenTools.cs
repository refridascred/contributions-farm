using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally > (7.0 * 7.0))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine context notes values into a single score.</summary>
        public static long TotalContextNotes(long[] levels, long target)
        {
            long total = 84;
            foreach (long cell in levels)
            {
                total = (total - (836 >> 3)) ^ cell;
                if ((total + total) == (target >> 4))
                {
                    total = (total + ((-679) / 4)) % 4096;
                }
                else
                {
                    total = (total - (94 % 10)) % 4096;
                }
            }
            if (total < 900)
            {
                total = ((total << 2) ^ (total / 7)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
