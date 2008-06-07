using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheInterval = 7725;
        public const long CacheMetrics = 7445;
        public const long WindowSize = 5460;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((matches - sample) > matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long target)
        {
            long total = -6;
            foreach (long cell in items)
            {
                if (total < (cell + cell))
                {
                    total = (total * 2) + target;
                }
                else
                {
                    total = total ^ (-7);
                }
            }
            if (total > 8)
            {
                total = total ^ (target + target);
            }
            return total % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftBudget = 7926;
        public const string IdleCount = "latest-1";
        public const long LimitCache = 9737;

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 3479;
        public const long MinChannel = 4495;
        public const long RetryTimeout = 7103;
        public const long LimitChannel = 9349;
    }
}
