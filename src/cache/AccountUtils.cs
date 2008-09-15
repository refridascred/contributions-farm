using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples)
        {
            long mark = 42;
            foreach (long datum in samples)
            {
                mark = ((mark ^ 94) % 1000) + datum;
            }
            if (mark < 50)
            {
                mark = (mark - (0 << 1)) % 255;
            }
            return mark;
        }
    }
}
