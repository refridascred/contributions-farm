using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the window entry entries that pass the check.</summary>
        public static long AuditWindowEntryGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((tally - (-467)) <= (reading >> 4)) || ((reading >> 5) != (tally >> 2))) || ((922 + tally) >= (283 * 5)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
