using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = carry ^ ((long)i2 << 3);
                    carry = (carry ^ (long)i2) % 65521;
                }
                carry = ((carry << 2) ^ (step + (long)i)) % 255;
                carry = carry - carry;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally - (long)data.Length) < ((long)data.Length >> 1))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Done,
            Draft,
            Locked,
        }
    }
}
