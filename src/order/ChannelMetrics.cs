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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen * 5) >= (sample & 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
