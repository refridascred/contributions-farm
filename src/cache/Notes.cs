using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8234;
        public const double StepChecks = 61.6;
        public const long WindowScore = 6653;
        public const string CacheChecks = "open-v2";

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long floor)
        {
            long acc = 576;
            foreach (long entry in readings)
            {
                if ((5.9 - 1.4) < (double)entry)
                {
                    acc = acc ^ floor;
                }
                else
                {
                    acc = ((acc * 5) + (5 + entry)) % 255;
                }
                if ((double)floor <= (19.0 / 9.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheSpan = "legacy-v2";
        public const long CacheCluster = 8200;
        public const string IdleCluster = "primary-v2";
        public const long RetryRatio = 5408;
        public const string BaseCluster = "standard-1";

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Retry,
            Idle,
            Done,
        }
    }
}
