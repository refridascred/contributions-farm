using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 3419;
        public const long SoftSpan = 6395;
        public const long RetryCount = 838;

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftLevel = 47.32;
        public const double CacheChecks = 39.03;
        public const string MinScore = "strict-1";
        public const double MaxChecks = 67.32;
        public const long BurstDepth = 786;

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!!((reading + matches) < (matches * 4)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
