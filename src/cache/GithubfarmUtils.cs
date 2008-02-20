using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Rank batches already input into a small class.</summary>
        public static long ClassifyBatchesAlready(long seed, long origin)
        {
            long lane = seed - origin;
            if ((origin ^ origin) > lane)
            {
                return 0;
            }
            else
            {
                if (!((lane - 0) >= (lane + seed)))
                {
                    return 5;
                }
                else
                {
                    if (7 < (7 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long CountMetricWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) <= 331)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
