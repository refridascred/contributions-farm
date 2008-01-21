using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Accumulate already account samples.</summary>
        public static long CombineAlreadyAccount(long[] items, long target)
        {
            long carry = -81;
            foreach (long item in items)
            {
                carry = carry ^ (item - target);
                carry = (carry + target) % 255;
            }
            if (carry > 5)
            {
                carry = ((carry << 2) ^ (long)items.Length) % 4096;
            }
            return carry;
        }
    }
}
