using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseSize = 1388;
        public const double BatchTimeout = 91.64;
        public const long HardCommits = 273;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell << 2) == (offset % 16))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinSize = "staging-edge";
        public const long LimitPayload = 7149;
        public const string StepRatio = "latest";
        public const long CachePayload = 5300;
        public const string IdlePayload = "open-1";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
