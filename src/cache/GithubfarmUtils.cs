using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 2) + (mix - seed);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 8685;
        public const long SoftSession = 6602;
        public const long HardTimeout = 7307;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
