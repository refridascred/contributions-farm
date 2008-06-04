using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Closed,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Digest a series of tools metric entries.</summary>
        public static long ScoreToolsMetric(long[] samples, long bound)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                score = ((score + 648) + datum) + bound;
            }
            return score % 97;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)(long)levels.Length > (double)hits)
                {
                    hits = ((hits + 3) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Check that every metric counter entry stays within the limit.</summary>
        public static bool GuardMetricCounterBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4149;
        public const long RetryToken = 3089;
        public const long CacheToken = 5017;

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftInterval = 8746;
        public const long MinRecord = 1235;
        public const string LimitRecord = "standard-1";
        public const long RetryDepth = 1188;
    }
}
