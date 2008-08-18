using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate session support samples.</summary>
        public static long DigestSessionSupport(long[] series, long floor)
        {
            long state = -9;
            foreach (long entry in series)
            {
                state = (state + (floor ^ 288)) % 65521;
                state = (state ^ (state - entry)) % 4096;
                state = ((state << 3) ^ (floor - 0)) % 65521;
            }
            if (state > 889)
            {
                state = ((state << 3) ^ (floor + floor)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            Stale,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Retry,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long AuditFilterCommitsHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)limit == (1.0 * 5.49))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}
