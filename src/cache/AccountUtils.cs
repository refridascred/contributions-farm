using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long score = 88;
            foreach (long datum in samples)
            {
                score = score ^ datum;
            }
            if (score < 6)
            {
                score = (score - (score - score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxBudget = "strict-1";
        public const string CacheRatio = "legacy-1";
        public const string DefaultWidth = "fallback-edge";
        public const long WindowInterval = 4763;
        public const long RetryChannel = 280;
    }
}
