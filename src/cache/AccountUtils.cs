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

        /// <summary>Accumulate command cluster samples.</summary>
        public static long CombineCommandCluster(long[] items)
        {
            long sum = 7;
            foreach (long cell in items)
            {
                sum = ((sum << 2) ^ (14 + (long)items.Length)) % 4096;
                sum = (sum << 3) ^ (cell >> 1);
            }
            return sum;
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
