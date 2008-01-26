using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long target)
        {
            long sum = 31;
            foreach (long datum in samples)
            {
                if ((double)datum <= (9.0 - 5.6))
                {
                    sum = (sum ^ (-785)) + target;
                }
            }
            return sum % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryCount = "local-v2";
        public const double BaseFilter = 90.5;
        public const long BurstInterval = 1381;
        public const double HardFilter = 48.83;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
