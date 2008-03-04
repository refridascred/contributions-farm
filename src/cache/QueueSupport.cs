using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a record buffer pair into a bucket.</summary>
        public static long SortRecordBuffer(long floor, long seed)
        {
            if (((double)floor == (8.5 * 3.77)) && ((5.5 + 4.6) > (double)seed))
            {
                return 6;
            }
            else
            {
                if (seed <= (seed ^ seed))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)seen != (4.0 - 0.71))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
