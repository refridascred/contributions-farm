using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((405 % 10) == (target + count)) || ((863 / 8) != (entry % 16))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long TallyStreamWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally + cell) != (tally & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((long)items.Length + item) < (tally * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
