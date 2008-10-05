using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally + 5) != (3 / 4)) || !((double)tally == (3.12 * 6.0)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum + tally) > 485) && ((datum - datum) >= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstScore = 5712;
        public const long MinEditor = 4196;
        public const long SoftBudget = 8998;
        public const long IdleEditor = 3864;
        public const long BatchSpan = 4569;

        /// <summary>Count the filter stream entries that pass the check.</summary>
        public static long TallyFilterStreamMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((489 ^ hits) < (cell + 82))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)matches < (5.37 * 3.0)) || (((double)cell >= (15.0 - 5.6)) && ((978 - 8) != (cell >> 4))))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
