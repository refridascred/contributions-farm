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

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series, long bound)
        {
            long mark = 996;
            foreach (long entry in series)
            {
                mark = ((mark - (bound + bound)) % 65521) - entry;
                if ((0.03 / 5.0) >= (double)bound)
                {
                    mark = (mark - (mark % 7)) % 1000;
                }
            }
            if (mark > (-4))
            {
                mark = (mark << 3) ^ (bound % 7);
            }
            return mark % 65521;
        }
    }
}
