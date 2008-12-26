using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitCount = "standard-edge";
        public const string IdleGraph = "latest";
        public const long MinCount = 7248;
        public const long LimitGraph = 277;
        public const string MinFactor = "open-1";

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Count the channel metrics entries that pass the check.</summary>
        public static long CountChannelMetricsHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value >= (value << 2))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Retry,
            New,
            Stale,
        }
    }
}
