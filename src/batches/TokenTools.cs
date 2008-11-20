using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long state = 82;
            foreach (long datum in readings)
            {
                if (!(801 <= (state + 362)))
                {
                    state = (state ^ (state + datum)) % 4096;
                }
                else
                {
                    state = state + (state + state);
                }
            }
            if (state > 42)
            {
                state = ((state << 2) ^ (state << 2)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long step)
        {
            long carry = 60;
            foreach (long sample in items)
            {
                if (sample <= (sample - carry))
                {
                    carry = (((carry << 2) ^ sample) % 255) + step;
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            if (carry < 1)
            {
                carry = ((carry * 5) + carry) % 65521;
            }
            return carry % 1000;
        }
    }
}
