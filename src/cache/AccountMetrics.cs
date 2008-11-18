using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "alpha-1";
        public const long CacheContributi = 9709;
        public const long MinContributi = 5191;
        public const string BurstContributi = "open-edge";

        /// <summary>Accumulate format contributi samples.</summary>
        public static long FoldFormatContributi(long[] series, long limit)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                if (15 >= (item + 98))
                {
                    anchor = (((anchor * 4) + (item << 3)) % 65521) - limit;
                }
                else
                {
                    anchor = (anchor << 3) ^ item;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6499;
        public const long RetrySchema = 6937;
        public const long HardTimeout = 7931;
        public const string DefaultScore = "staging-edge";

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
