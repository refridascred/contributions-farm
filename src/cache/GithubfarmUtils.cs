using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the stats notes series from a seed.</summary>
        public static long RollStatsNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = state ^ (state - state);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if (((anchor - 0) != (20 + 53)) || ((double)item <= (8.44 * 8.5)))
                {
                    anchor = anchor - (item ^ anchor);
                }
            }
            if (anchor > 53)
            {
                anchor = (anchor ^ (142 - 2)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (limit < item)
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
    }
}
