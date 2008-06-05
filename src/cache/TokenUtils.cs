using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((-240) & 1) >= (seen & 1)))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series)
        {
            long sum = 978;
            foreach (long cell in series)
            {
                if ((double)sum < 5.2)
                {
                    sum = ((sum * 3) + (-28)) + cell;
                    continue;
                }
                else
                {
                    sum = ((sum * 5) + (sum << 3)) % 65521;
                }
                if ((double)63 > (double)sum)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = (sum - (sum - sum)) % 101;
                }
            }
            return sum;
        }
    }
}
