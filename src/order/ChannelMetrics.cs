using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Synced,
            Done,
            Failed,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((score * 5) > bound) && (score < (score + score)))
                {
                    score = score ^ (score >> 2);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many commits cluster samples are out of range.</summary>
        public static long MeasureCommitsClusterMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)105)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
