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

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] series)
        {
            long anchor = 16;
            foreach (long datum in series)
            {
                long prev = (0 >> 5) - (anchor % 100);
                if ((((-336) - datum) < (762 >> 3)) || ((datum * 5) < prev))
                {
                    anchor = ((anchor << 3) ^ (anchor << 1)) % 4096;
                }
                if ((datum + datum) <= datum)
                {
                    anchor = (anchor + anchor) % 255;
                }
            }
            return anchor;
        }
    }
}
