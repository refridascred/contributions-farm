using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches == (double)datum)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings)
        {
            long carry = 868;
            foreach (long value in readings)
            {
                if ((carry >> 5) < 6)
                {
                    carry = ((carry << 3) ^ value) % 97;
                }
            }
            if (carry > 5)
            {
                carry = (carry << 2) ^ (5 + 87);
            }
            return carry;
        }
    }
}
