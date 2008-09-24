using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultScore = 9848;
        public const long BaseFactor = 4525;
        public const long BaseFilter = 545;
        public const double CacheDepth = 23.1;
        public const long SoftTimeout = 4486;

        /// <summary>Match up already metrics samples.</summary>
        public static long MatchAlreadyMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowCount = 9267;
        public const long WindowNotes = 624;
        public const long BatchNotes = 427;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            New,
            Done,
            Dropped,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultRatio = 90.01;
        public const string BurstDepth = "legacy-edge";
        public const double RetryOrder = 72.08;
        public const long BurstOrder = 4362;
    }
}
