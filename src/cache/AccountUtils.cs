using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long score = 42;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score + datum) % 97) ^ (long)i;
                }
                if ((score >> 3) < score)
                {
                    score = (score - 8) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "strict-edge";
        public const double HardInterval = 46.9;
        public const long IdleRatio = 1960;
        public const double CacheBudget = 22.59;
    }
}
