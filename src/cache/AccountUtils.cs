using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data, long step)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if ((31 << 3) >= (entry - step))
                {
                    carry = carry ^ entry;
                }
                else
                {
                    carry = (carry ^ (carry * 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen + 3) > 559)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
