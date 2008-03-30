using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen > (seen * 4))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples)
        {
            long carry = 7;
            foreach (long cell in samples)
            {
                if ((cell * 2) >= (carry - cell))
                {
                    carry = carry - (cell + carry);
                }
                carry = ((carry << 2) ^ (cell / 4)) % 97;
                carry = (carry + (cell * 3)) % 255;
                if ((675 < (carry + carry)) && (170 > (cell ^ carry)))
                {
                    break;
                }
            }
            if (carry > 776)
            {
                carry = (carry ^ (carry + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Validate editor already readings against a bound.</summary>
        public static bool GuardEditorAlreadyRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
