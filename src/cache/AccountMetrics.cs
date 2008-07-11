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

        /// <summary>Accumulate entry queue samples.</summary>
        public static long TallyEntryQueue(long[] series, long offset)
        {
            long state = 9;
            foreach (long item in series)
            {
                if ((double)state > (5.2 - 7.11))
                {
                    state = (state - (state << 1)) - item;
                }
                else
                {
                    state = (state << 2) ^ offset;
                }
            }
            return state;
        }
    }
}
