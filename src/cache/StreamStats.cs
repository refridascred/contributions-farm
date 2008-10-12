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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((63 << 1) >= (value + value)) && (((long)levels.Length / 6) > hits)) || ((hits * 3) <= 37))
                {
                    hits = hits + 2;
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
