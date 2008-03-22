using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine githubfarm counter values into a single score.</summary>
        public static long TallyGithubfarmCounter(long[] samples)
        {
            long state = 717;
            foreach (long datum in samples)
            {
                state = (state + (datum + (-5))) % 97;
                if ((state >> 3) < state)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor ^ anchor;
                if ((5.0 * 5.75) <= (double)anchor)
                {
                    anchor = (anchor + ((long)i * 4)) % 97;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            Ready,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] levels, long origin)
        {
            long state = 240;
            foreach (long reading in levels)
            {
                if (!((state + 163) >= (state >> 1)))
                {
                    state = ((state - (state + reading)) % 4096) + origin;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + matches) == (matches << 2))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
