using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit layout format readings against a rule.</summary>
        public static long AuditLayoutFormatMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (276 > (262 - seen))
                {
                    seen = ((seen + 2) ^ sample) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Retry,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Locked,
            Closed,
        }
    }
}
