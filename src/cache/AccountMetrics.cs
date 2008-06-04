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

        /// <summary>Iterate the order stream series from a seed.</summary>
        public static long RollOrderStream(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + (seed + anchor)) % 97;
                anchor = ((anchor << 3) ^ ((long)i & 127)) % 101;
                if ((seed >> 3) >= seed)
                {
                    anchor = (anchor << 3) ^ (seed % 100);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
