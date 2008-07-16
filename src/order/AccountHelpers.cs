using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 930;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score - item);
            }
            return score % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 885;
        public const double BatchRatio = 42.84;
        public const long BurstCluster = 9128;
        public const long BurstRatio = 3851;
        public const long StepCluster = 1383;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchBudget = 92.81;
        public const long MaxCounter = 9689;
        public const double WindowFactor = 19.7;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 4588;
        public const string DefaultTimeout = "latest-1";
        public const long RetryCount = 3437;
        public const double CacheScore = 31.53;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen <= 5)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
