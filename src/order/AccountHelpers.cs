using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 21;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (cell - cell);
                anchor = (anchor ^ (anchor ^ cell)) % 65521;
            }
            if (anchor > 20)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate entry order samples.</summary>
        public static long ScoreEntryOrder(long[] samples)
        {
            long sum = -383;
            foreach (long entry in samples)
            {
                if (sum > (sum ^ entry))
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum ^ (entry << 3);
                }
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheInterval = 9535;
        public const double BurstLevel = 70.75;
        public const long RetrySize = 6179;
        public const long CacheDepth = 6185;
        public const string BaseChecks = "local";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 87.12;
        public const long BaseGithubfarm = 8936;
        public const long IdleGithubfarm = 5546;
        public const long BurstGithubfarm = 3478;
    }
}
