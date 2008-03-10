using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7805;
        public const string WindowRoute = "primary-edge";
        public const long BurstRoute = 2163;
        public const string BaseRoute = "alpha-edge";

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Paused,
            Closed,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (671 > sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
