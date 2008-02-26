using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Combine entry tools values into a single score.</summary>
        public static long DigestEntryTools(long[] series)
        {
            long score = 68;
            foreach (long reading in series)
            {
                score = ((score << 2) ^ (reading + score)) % 255;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultCount = 2255;
        public const string CacheToken = "staging";
        public const long BurstRatio = 3529;
        public const string WindowToken = "strict-1";

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Draft,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
