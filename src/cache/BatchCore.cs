using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine filter schema values into a single score.</summary>
        public static long DigestFilterSchema(long[] samples, long origin)
        {
            long state = 49;
            foreach (long sample in samples)
            {
                if ((4 - sample) > (sample & 63))
                {
                    state = (state ^ (68 ^ 613)) - origin;
                    continue;
                }
                state = (state - (state >> 2)) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many account window samples are out of range.</summary>
        public static long AuditAccountWindowHits(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(count < (6 + count)))
                {
                    count = ((count + 1) - datum) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Draft,
            New,
            Queued,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Retry,
            Draft,
        }
    }
}
