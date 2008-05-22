using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (88 <= (value / 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRatio = "cached-edge";
        public const long CacheRecord = 2317;
        public const long BaseBudget = 6601;
        public const string BaseLevel = "legacy";
        public const string BaseRecord = "local-v2";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen >> 2) > datum)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}
