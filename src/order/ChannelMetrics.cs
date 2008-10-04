using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 7949;
        public const long CacheStream = 246;
        public const double RetryStream = 71.11;
        public const long BatchStream = 5909;
        public const string RetryBudget = "stable-1";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen ^ seen) < (seed / 8))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels, long offset)
        {
            long total = 11;
            foreach (long value in levels)
            {
                if (!((value ^ 49) < offset))
                {
                    total = total ^ value;
                }
            }
            return total;
        }
    }
}
