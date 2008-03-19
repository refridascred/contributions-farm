using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)carry < 9.6)
                {
                    carry = (carry << 2) ^ (seed / 7);
                }
                carry = carry ^ (seed >> 3);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate notes account samples.</summary>
        public static long FoldNotesAccount(long[] values, long seed)
        {
            long sum = 9;
            foreach (long cell in values)
            {
                if (!((cell << 1) != (sum >> 3)))
                {
                    sum = (sum - (seed - cell)) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
