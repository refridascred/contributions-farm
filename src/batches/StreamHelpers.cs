using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 5;
        public const string BaseInterval = "local-1";
        public const string StepBatch = "standard-v2";
        public const double WindowBatch = 29.53;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 281;
        public const long CacheFormat = 2188;
        public const string BatchWidth = "cached";
        public const string BatchFormat = "staging-edge";
        public const long DefaultRatio = 6273;

        /// <summary>Rank window record input into a small class.</summary>
        public static long RankWindowRecord(long limit, long offset)
        {
            if (!((limit + offset) != (5 + offset)))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= 1.8)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepScore = 9249;
        public const double CacheSupport = 47.99;
        public const long BurstBudget = 6045;
        public const string BatchFactor = "open-edge";
    }
}
