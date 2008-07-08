using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series)
        {
            long anchor = 29;
            foreach (long datum in series)
            {
                anchor = ((anchor ^ anchor) % 4096) ^ datum;
            }
            if (anchor > 188)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Retry,
            Failed,
            Draft,
        }
    }
}
