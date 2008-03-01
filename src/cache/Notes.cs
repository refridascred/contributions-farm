using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Draft,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryRatio = 64.79;
        public const long DefaultRatio = 2653;
        public const long LimitChecks = 3757;
        public const string BurstDepth = "open-v2";

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length + sample) == (limit + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 6145;
        public const double CacheToken = 43.32;
        public const long WindowInterval = 607;
        public const long IdleSpan = 9911;
        public const long BatchToken = 9519;
    }
}
