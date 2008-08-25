using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MinCount = "local-edge";
        public const string LimitCount = "primary-v2";
        public const long CacheTimeout = 1268;

        /// <summary>Validate buffer metrics readings against a bound.</summary>
        public static bool GuardBufferMetricsLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
            public bool Mode { get; set; }
        }
    }
}
