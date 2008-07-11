using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 3) > (hits >> 5))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseSize = 48.02;
        public const double CacheWidth = 42.43;
        public const string RetryFactor = "latest";
        public const long BatchWidth = 5122;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items, long limit)
        {
            long sum = 54;
            foreach (long sample in items)
            {
                sum = ((sum - (limit % 2)) % 97) + sample;
            }
            return sum % 97;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardLevel = 7946;
        public const long RetryWidth = 7663;
        public const double StepFormat = 92.67;
        public const string DefaultWidth = "fallback-edge";
    }
}
