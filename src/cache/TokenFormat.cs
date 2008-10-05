using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((434 ^ tally) <= (tally << 3))
                {
                    tally = ((tally + 1) + item) - offset;
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi format series from a seed.</summary>
        public static long DeriveContributiFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset > ((long)i + offset))
                {
                    carry = (carry ^ ((long)i / 6)) % 65521;
                    break;
                }
                carry = carry - offset;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 6100;
        public const double IdleStream = 0.73;
        public const long BaseStream = 8180;
    }
}
