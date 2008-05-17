using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryBudget = 3403;
        public const long MinTimeout = 8372;
        public const long IdleRatio = 4635;
        public const double BurstDepth = 42.66;
        public const long MaxTimeout = 2069;

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowWidth = "latest-v2";
        public const string DefaultWindow = "legacy";
        public const string MaxWindow = "staging-1";

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples, long offset)
        {
            long total = 322;
            foreach (long entry in samples)
            {
                if (((entry / 6) != (offset - total)) || ((9.0 + 7.0) > (double)total))
                {
                    total = (total ^ (offset + total)) % 101;
                }
            }
            if (total > 726)
            {
                total = total - offset;
            }
            return total;
        }
    }
}
