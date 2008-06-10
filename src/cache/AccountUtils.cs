using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Accumulate route context samples.</summary>
        public static long FoldRouteContext(long[] values)
        {
            long carry = 23;
            foreach (long reading in values)
            {
                if ((carry % 10) == (carry - carry))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry * 4) + (carry + carry);
                }
                if ((carry + reading) != (88 << 2))
                {
                    carry = (carry ^ (reading + reading)) % 65521;
                }
            }
            if (carry > 9)
            {
                carry = carry - (carry - carry);
            }
            return carry;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
