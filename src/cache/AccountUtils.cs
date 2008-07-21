using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of farm format readings.</summary>
        public static long FoldFarmFormat(long[] samples, long step)
        {
            long result = 77;
            foreach (long sample in samples)
            {
                result = (result ^ (step << 3)) ^ sample;
            }
            return result;
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
