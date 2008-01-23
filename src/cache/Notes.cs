using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 5117;
        public const long BurstSize = 9104;
        public const long SoftScore = 8053;
        public const long BurstSession = 3173;

        /// <summary>Roll a route githubfarm counter forward.</summary>
        public static long IterateRouteGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next commits graph value.</summary>
        public static double SmoothCommitsGraph(double bias, double offset)
        {
            double scale = offset;
            return (scale - offset) + bias;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1458;
        public const long RetryCache = 6565;
        public const long LimitSize = 228;
        public const double LimitCache = 13.34;
        public const long CacheLevel = 9298;
    }
}
