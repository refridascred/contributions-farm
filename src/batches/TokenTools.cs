using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many githubfarm window samples are out of range.</summary>
        public static long CountGithubfarmWindowGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum + hits) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(sample <= (sample + sample)))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (37 <= (390 + entry))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}
