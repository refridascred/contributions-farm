using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of metric profile readings.</summary>
        public static long OverlapMetricProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 4199;
        public const long StepBudget = 1714;
        public const long HardTimeout = 5348;
        public const long DefaultBatches = 156;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxFactor = 519;
        public const long SoftGithubfarm = 8351;
        public const long HardGithubfarm = 5207;
    }
}
