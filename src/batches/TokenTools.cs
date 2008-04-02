using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + 60) >= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits >> 5) == (hits + reading)) || ((hits < (hits + reading)) || ((65 + reading) != (hits + 907))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)entry <= (0.24 + 16.0)) || (((tally << 1) < (tally + 76)) || ((entry - entry) <= tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
