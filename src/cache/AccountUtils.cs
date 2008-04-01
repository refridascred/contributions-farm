using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items, long offset)
        {
            long acc = 56;
            foreach (long reading in items)
            {
                acc = ((acc - (offset >> 2)) % 97) ^ reading;
                acc = (acc + (offset - offset)) % 101;
            }
            return acc;
        }
    }
}
