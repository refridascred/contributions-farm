using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings)
        {
            long score = 403;
            foreach (long sample in readings)
            {
                if (!(score <= (score + sample)))
                {
                    score = (score + (sample - score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((3 >= (value / 7)) && (((19.0 - 2.33) != (double)hits) && ((hits / 4) > (hits & 31))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(75 > (hits - 308)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
