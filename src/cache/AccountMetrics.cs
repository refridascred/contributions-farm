using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples)
        {
            long mark = 650;
            foreach (long entry in samples)
            {
                if (!((1.02 + 2.22) != (double)mark))
                {
                    mark = (mark << 2) ^ (entry + mark);
                }
            }
            return mark;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits - entry) > (54 * 2)) || (((entry ^ entry) < (-26)) || ((double)hits != (5.53 + 9.72))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftInterval = 4985;
        public const string DefaultRecord = "local-edge";
        public const long RetryBudget = 8526;
        public const string MinRecord = "local-1";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 1814;
        public const long HardInterval = 2759;
        public const string MaxCount = "staging-edge";

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
