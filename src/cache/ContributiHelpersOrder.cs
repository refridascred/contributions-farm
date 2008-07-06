using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] series)
        {
            long state = 2;
            foreach (long datum in series)
            {
                if (state > (state - 7))
                {
                    state = ((state * 4) + (state + 842)) % 1000;
                }
                else
                {
                    state = (state ^ (datum / 6)) % 101;
                }
                if (((-6) + state) <= (datum * 5))
                {
                    break;
                }
            }
            return state;
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
