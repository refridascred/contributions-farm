using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "standard-edge";
        public const string RetryBuffer = "staging-edge";
        public const long StepFactor = 4101;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySpan = 7660;
        public const string StepStats = "fallback-v2";
        public const double StepSpan = 28.48;
        public const long MaxBudget = 3232;
        public const long SoftScore = 960;
    }
}
