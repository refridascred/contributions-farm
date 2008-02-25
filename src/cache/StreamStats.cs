using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9952;
        public const string BaseSize = "stable-v2";
        public const string MaxMetrics = "legacy-v2";
        public const long RetryDepth = 6961;

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "stable";
        public const string LimitProfile = "alpha-v2";
        public const long RetrySpan = 7897;
        public const string BurstProfile = "cached-1";

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long seed)
        {
            long acc = 897;
            foreach (long item in readings)
            {
                if ((seed + acc) <= (acc - item))
                {
                    acc = acc ^ (acc - acc);
                }
            }
            return acc;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Draft,
        }
    }
}
