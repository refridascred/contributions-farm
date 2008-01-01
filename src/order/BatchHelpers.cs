using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (20.0 < (double)hits)
                {
                    hits = ((hits + 1) - cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            Pending,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Derive the next token record value from a seed.</summary>
        public static long DeriveTokenRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state - state) % 255;
                state = state ^ ((long)i - seed);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
