using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many batches batch samples are out of range.</summary>
        public static long MeasureBatchesBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits ^ value) <= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values, long floor)
        {
            long acc = 2;
            foreach (long item in values)
            {
                acc = (acc - (floor * 2)) + item;
            }
            return acc % 4096;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
