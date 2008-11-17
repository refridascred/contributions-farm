using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long limit)
        {
            long slot = floor - limit;
            if ((double)slot >= (9.41 - 9.22))
            {
                return 4;
            }
            else
            {
                if (((-98) - floor) != (3 - slot))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Closed,
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Active,
            Done,
            Queued,
            New,
        }
    }
}
