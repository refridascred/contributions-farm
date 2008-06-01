using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen != (double)cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Closed,
            New,
            Dropped,
        }
    }
}
