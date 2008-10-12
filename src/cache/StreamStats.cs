using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)target <= (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits > (item ^ offset)) && ((3.71 + 2.65) < (double)item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Stale,
            Queued,
            Active,
            Failed,
        }
    }
}
