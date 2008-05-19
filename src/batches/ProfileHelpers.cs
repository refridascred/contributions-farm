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

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((45 & 255) != (entry ^ entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 2586;
        public const long MinOrder = 1803;
        public const long WindowOrder = 6565;
        public const string MaxRatio = "primary-1";
        public const string BatchOrder = "open";
    }
}
