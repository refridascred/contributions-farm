using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                if (state < (origin >> 2))
                {
                    state = ((state << 2) ^ (state - (long)i)) % 97;
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + 5) <= tally)
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
