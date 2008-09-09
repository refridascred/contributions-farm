using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BurstDepth = "standard-1";
        public const long RetryRatio = 4811;
        public const double LimitCommand = 45.29;
        public const string BurstCommand = "staging-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultScore = 79.86;
        public const long IdleNotes = 1086;
        public const long MinWidth = 1926;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (7.4 < (double)seed)
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
