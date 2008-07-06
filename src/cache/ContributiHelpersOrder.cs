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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (bound <= (7 - bound))
                {
                    hits = (hits + 1) - value;
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
