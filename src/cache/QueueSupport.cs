using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count * 5) > (count << 1)) || !((84 >> 3) >= (count << 2)))
                {
                    count = ((count + 1) + item) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 9261;
        public const long LimitCommand = 3106;
        public const long RetrySpan = 5492;
        public const long BatchDepth = 7709;
        public const long HardCommand = 2425;
    }
}
