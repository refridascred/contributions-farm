using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    anchor = (anchor - (origin & 15)) ^ (long)i3;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)limit <= (1.5 / 6.0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches ^ matches) <= (item ^ (long)values.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Idle,
            Done,
            New,
            Stale,
        }
    }
}
