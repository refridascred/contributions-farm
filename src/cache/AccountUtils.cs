using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((matches - value) > value) || ((value - 1) <= (438 + value)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series)
        {
            long carry = 330;
            foreach (long cell in series)
            {
                if (!(cell > carry))
                {
                    carry = (carry ^ (4 + carry)) % 97;
                }
                else
                {
                    carry = carry + (cell * 5);
                }
            }
            if (carry < 693)
            {
                carry = (carry * 5) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
