using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a notes account counter forward.</summary>
        public static long DeriveNotesAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values)
        {
            long carry = 1;
            foreach (long datum in values)
            {
                if ((1.04 + 1.79) > (double)carry)
                {
                    carry = carry - (carry + datum);
                    continue;
                }
                if (((carry / 4) >= datum) && ((datum + carry) < carry))
                {
                    carry = ((carry * 5) + datum) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings, long seed)
        {
            long state = -652;
            foreach (long datum in readings)
            {
                state = state + (datum + state);
            }
            if (state > 17)
            {
                state = ((state * 3) + (seed - seed)) % 101;
            }
            return state;
        }
    }
}
