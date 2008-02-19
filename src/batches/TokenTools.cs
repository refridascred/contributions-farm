using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the filter session entries that pass the check.</summary>
        public static long CountFilterSessionMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 8) >= step)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 64) >= (hits % 24))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seed * 5) >= (seed % 60))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
