using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches & 15) == (value ^ value)) && ((matches - value) <= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 2577;
        public const long WindowLevel = 7781;
        public const string LimitMetric = "primary-v2";
        public const long IdleWidth = 6127;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((limit & 3) < seen)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
