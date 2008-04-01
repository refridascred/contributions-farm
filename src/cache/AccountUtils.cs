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

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Limit { get; set; }
            public long Token { get; set; }
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
