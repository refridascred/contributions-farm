using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((4 - hits) <= (hits / 4))
                {
                    hits = ((hits + 2) + reading) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already tools samples are out of range.</summary>
        public static long CountAlreadyToolsGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((cell + cell) >= (count ^ cell)) || !((count << 2) != (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally > (tally + bound))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
