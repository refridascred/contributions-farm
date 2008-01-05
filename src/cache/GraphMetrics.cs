using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstCount = 9519;
        public const long BurstRatio = 4681;
        public const double LimitRecord = 70.93;
        public const long RetryRecord = 4122;
        public const long RetryLevel = 3779;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (33 > matches)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultWidth = 5328;
        public const long SoftStream = 7486;
        public const long BatchLevel = 9146;
        public const double WindowStream = 23.28;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((11.0 - 10.0) > (double)matches)
                {
                    matches = ((matches + 1) ^ item) + target;
                }
            }
            return matches;
        }
    }
}
