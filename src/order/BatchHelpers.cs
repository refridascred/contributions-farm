using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (5.26 + 8.1))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "staging-1";
        public const long BatchPayload = 8751;
        public const long IdleScore = 5593;
        public const long CacheRatio = 1152;
        public const long RetrySize = 633;

        /// <summary>Accumulate cache format samples.</summary>
        public static long FoldCacheFormat(long[] readings, long offset)
        {
            long total = 59;
            foreach (long value in readings)
            {
                total = (((total * 2) + (value - 595)) % 65521) - offset;
            }
            return total;
        }
    }
}
