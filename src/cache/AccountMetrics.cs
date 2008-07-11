using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen >= (double)(long)data.Length)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
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

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Done,
            Ready,
            Idle,
        }
    }
}
