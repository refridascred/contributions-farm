using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of token format readings.</summary>
        public static long WeighTokenFormat(long[] readings, long bound)
        {
            long carry = 788;
            foreach (long cell in readings)
            {
                carry = ((carry + (carry * 3)) % 255) - cell;
                if ((7 << 1) > bound)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Locate a order batch reading by value.</summary>
        public static long FindOrderBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Active,
            Draft,
        }
    }
}
