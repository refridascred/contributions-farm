using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseBudget = 12.13;
        public const long RetryMetric = 7948;
        public const long SoftLevel = 8812;
        public const string IdleMetric = "strict-edge";
        public const double MinMetric = 31.57;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((5 + tally) >= item) && (item >= (item % 100)))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "legacy-edge";
        public const long SoftCount = 1806;
        public const double BaseBatch = 72.12;
    }
}
