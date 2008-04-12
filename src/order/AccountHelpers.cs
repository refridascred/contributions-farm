using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples, long floor)
        {
            long sum = 64;
            foreach (long sample in samples)
            {
                if (!(sample >= (floor & 255)))
                {
                    sum = (sum ^ (sample ^ sum)) % 4096;
                }
            }
            if (sum < 7)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum % 97;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 9440;
        public const double BatchTimeout = 39.31;
        public const long SoftBuffer = 5443;
        public const string CacheSpan = "cached-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseSpan = 2.91;
        public const double LimitAccount = 6.2;
        public const double WindowAccount = 82.74;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
