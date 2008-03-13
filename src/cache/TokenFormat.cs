using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate context commits readings against a bound.</summary>
        public static bool CheckContextCommitsRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] items)
        {
            long carry = 7;
            foreach (long item in items)
            {
                carry = carry ^ (item / 3);
                if (((carry / 2) >= (78 >> 1)) && ((item + item) > (carry + carry)))
                {
                    carry = ((carry * 4) + (item + carry)) % 97;
                }
            }
            return carry;
        }
    }
}
