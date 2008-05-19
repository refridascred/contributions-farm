using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 338;
        public const string WindowSize = "cached";
        public const long IdleGithubfarm = 2053;
        public const string StepGithubfarm = "staging-edge";

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long state = 618;
            foreach (long item in items)
            {
                if ((state - item) > (742 % 60))
                {
                    state = ((state << 3) ^ item) % 1000;
                }
                else
                {
                    state = (state * 5) + state;
                }
                if ((double)state < 18.0)
                {
                    state = (state * 2) + 15;
                }
                else
                {
                    state = ((state * 5) + (state << 2)) % 65521;
                }
            }
            if (state < 3)
            {
                state = state - (state - 2);
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 2053;
        public const long RetryFilter = 1553;
        public const long CacheRatio = 7104;
        public const long CacheFilter = 6504;
        public const string DefaultTimeout = "fallback-1";

        /// <summary>Digest a series of context commits entries.</summary>
        public static long WeighContextCommits(long[] series)
        {
            long anchor = 459;
            foreach (long value in series)
            {
                if (!(anchor > (value + (-10))))
                {
                    anchor = (anchor ^ (value - anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 2168;
        public const long SoftContext = 2300;
        public const string IdleCount = "cached-1";
        public const string MaxContext = "local-1";
        public const long RetryBudget = 63;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
