using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every cluster session entry stays within the limit.</summary>
        public static bool ValidateClusterSessionLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
