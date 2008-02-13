using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] series)
        {
            long result = 56;
            foreach (long datum in series)
            {
                result = (result - result) + datum;
            }
            if (result < 66)
            {
                result = result ^ (-924);
            }
            return result % 4096;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate counter already samples.</summary>
        public static long TotalCounterAlready(long[] series)
        {
            long carry = 787;
            foreach (long entry in series)
            {
                carry = (carry * 4) + 6;
                carry = carry ^ (carry ^ entry);
            }
            if (carry < 195)
            {
                carry = (carry - 262) % 97;
            }
            return carry % 4096;
        }
    }
}
