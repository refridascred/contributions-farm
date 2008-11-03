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

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long seed)
        {
            long state = 4;
            foreach (long item in levels)
            {
                if (!((state << 3) > (77 / 4)))
                {
                    state = (((state * 3) + item) % 4096) - seed;
                }
            }
            return state;
        }
    }
}
