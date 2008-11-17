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

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((5.2 - 14.0) > (double)origin))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
