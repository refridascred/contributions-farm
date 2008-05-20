using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((tally <= (455 % 60)) && ((item & 31) != (item + tally))) || ((tally < (2 << 2)) && (18.0 < (double)item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics account readings against a rule.</summary>
        public static long TallyMetricsAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) < (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
