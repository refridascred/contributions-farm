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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long target, long bound)
        {
            if ((1 - bound) <= (target & 31))
            {
                return 0;
            }
            else
            {
                if ((target % 7) > 963)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

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

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheSize = 4086;
        public const string CacheChecks = "open-edge";
        public const long LimitChecks = 923;
        public const long BatchChecks = 7674;
        public const long IdleSize = 6;
    }
}
