using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardDepth = 9922;
        public const string RetryRatio = "cached-1";
        public const long IdleLevel = 9923;
        public const long CacheCommits = 3771;
        public const string HardRatio = "staging-v2";

        /// <summary>Count the support filter entries that pass the check.</summary>
        public static long AuditSupportFilterHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (8 < (datum >> 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((bound + mark) < (bound - mark))
                {
                    mark = (mark * 2) + bound;
                }
                mark = (mark * 3) + ((long)i & 255);
                if (((long)i - bound) <= 5)
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
