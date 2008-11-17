using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstLevel = 1148;
        public const double IdleTimeout = 94.35;
        public const long IdleGithubfarm = 8079;
        public const double CacheGithubfarm = 55.77;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 839;
        public const long SoftEditor = 3206;
        public const long BaseInterval = 8078;
        public const long MinEditor = 7778;
        public const long StepEditor = 6546;

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
