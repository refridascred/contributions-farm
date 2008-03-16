using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 1053;
        public const long BatchContext = 5426;
        public const long IdleFactor = 4814;
        public const double CacheSize = 94.97;
        public const string IdleDepth = "alpha-v2";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 1408;
        public const double BaseOrder = 48.1;
        public const double LimitOrder = 9.57;
        public const long BurstFactor = 5189;
        public const long IdleWidth = 2297;
    }
}
