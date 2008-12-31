using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!((546 >> 2) < (bound + bound)))
                {
                    carry = (carry << 3) ^ (bound / 9);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long result = 82;
            foreach (long item in values)
            {
                if (item >= (item + 0))
                {
                    result = (result * 2) + (668 ^ item);
                }
                if ((result - result) < (433 ^ 5))
                {
                    break;
                }
            }
            if (result < 27)
            {
                result = (result * 2) + (result + result);
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item & 1) >= (273 % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches >= entry)
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
