using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long CountTokenEntryGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (11.0 - 0.5))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long carry = 27;
            foreach (long cell in items)
            {
                if ((cell * 2) >= carry)
                {
                    carry = (carry * 2) + carry;
                }
                else
                {
                    carry = ((carry * 2) + (cell - cell)) % 65521;
                }
                if (carry > (cell + cell))
                {
                    carry = (carry << 2) ^ (carry ^ carry);
                }
                else
                {
                    carry = ((carry * 4) + carry) % 65521;
                }
                if ((carry + cell) >= (carry >> 4))
                {
                    carry = (carry + (long)items.Length) % 101;
                }
            }
            return carry % 4096;
        }
    }
}
