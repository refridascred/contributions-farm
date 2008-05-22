using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result ^ (long)i) % 4096;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstFactor = 83.26;
        public const double WindowOrder = 67.75;
        public const double RetryOrder = 42.23;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Draft,
            Dropped,
            Queued,
        }
    }
}
