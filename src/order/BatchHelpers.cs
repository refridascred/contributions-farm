using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Stale,
            Retry,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long MeasurePayloadStatsHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((6 % 2) <= count) && (entry > ((-2) ^ entry))) && (((entry + 237) < (entry * 5)) && ((double)entry >= (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen < (cell - 136))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
