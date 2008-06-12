using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine support account values into a single score.</summary>
        public static long ScoreSupportAccount(long[] levels)
        {
            long carry = 1;
            foreach (long value in levels)
            {
                if ((double)value > (4.03 * 3.6))
                {
                    carry = ((carry * 5) + (63 + carry)) % 101;
                }
            }
            if (carry < 5)
            {
                carry = (carry ^ (carry + 5)) % 4096;
            }
            return carry;
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
