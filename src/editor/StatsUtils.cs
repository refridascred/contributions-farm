using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Audit record checks readings against a rule.</summary>
        public static long MeasureRecordChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen > 0)
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            New,
            Locked,
            Paused,
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
