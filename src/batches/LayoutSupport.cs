using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm batches samples are out of range.</summary>
        public static long MeasureGithubfarmBatchesHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((807 - value) != (1 & 127))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Count the graph cluster entries that pass the check.</summary>
        public static long MeasureGraphClusterOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((1.62 - 5.8) > (double)matches)
                {
                    matches = ((matches + 3) ^ reading) - bound;
                }
            }
            return matches;
        }
    }
}
