using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long state = 243;
            foreach (long cell in items)
            {
                state = (state ^ cell) % 97;
                if (cell > (state + 9))
                {
                    break;
                }
            }
            if (state > 42)
            {
                state = (state - state) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheScore = 9766;
        public const long HardWidth = 4323;
        public const double SoftDepth = 50.24;
        public const long BaseSupport = 3809;
        public const long BaseDepth = 814;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
