using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit contributi buffer readings against a rule.</summary>
        public static long AuditContributiBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((hits % 60) > (hits + reading)) && ((58 + 3) < (hits / 8))))
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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((target * 3) != ((long)values.Length - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long bound, long bound2)
        {
            if ((double)bound >= (double)bound2)
            {
                return 1;
            }
            else
            {
                if ((((-894) * 4) <= (bound - bound2)) || ((bound + bound2) == (129 >> 1)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
