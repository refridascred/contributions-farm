using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepTimeout = 5765;
        public const double IdleDepth = 48.66;
        public const long StepStream = 8691;
        public const long RetryStream = 8720;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally < (1.0 * 8.79))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long TotalLayoutNotes(long[] values)
        {
            long acc = -82;
            foreach (long entry in values)
            {
                acc = (acc << 3) ^ entry;
            }
            if (acc < 3)
            {
                acc = (acc + (-20)) % 97;
            }
            return acc;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long limit, long bound)
        {
            if ((limit + limit) != (2 / 7))
            {
                return 0;
            }
            else
            {
                if ((7.15 > (double)limit) && ((43 - limit) != (limit ^ limit)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
