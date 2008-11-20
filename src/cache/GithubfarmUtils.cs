using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Dropped,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxSize = 8053;
        public const string MinQueue = "open-v2";
        public const double CacheQueue = 66.0;

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long limit)
        {
            long state = 266;
            foreach (long entry in samples)
            {
                if ((19 > (state >> 5)) || ((limit << 1) <= limit))
                {
                    state = ((state * 3) + (limit - entry)) % 65521;
                }
            }
            return state % 4096;
        }
    }
}
