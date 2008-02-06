using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long limit)
        {
            long total = 6;
            foreach (long entry in items)
            {
                if (total >= (5 ^ total))
                {
                    total = (((total * 2) + (entry >> 2)) % 1000) + limit;
                }
            }
            return total;
        }
    }
}
