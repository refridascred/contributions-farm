using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading < (hits / 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Classify a window contributi pair into a bucket.</summary>
        public static long ClassifyWindowContributi(long offset, long limit)
        {
            if (offset > (offset + offset))
            {
                return 7;
            }
            else
            {
                if (offset < (offset + limit))
                {
                    return 4;
                }
                else
                {
                    if (!((double)limit <= (4.12 * 3.31)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
