using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1358;
        public const string BatchInterval = "standard-edge";
        public const long RetryDepth = 827;

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
