using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings, long target)
        {
            long anchor = -55;
            foreach (long item in readings)
            {
                anchor = ((anchor * 2) + (item + item)) + target;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits / 4) >= (offset % 2))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm cluster readings against a rule.</summary>
        public static long TallyGithubfarmClusterHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((3.0 + 3.0) > (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
