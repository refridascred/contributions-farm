using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((double)reading > (0.66 + 5.1)) || ((5.35 / 2.0) == (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items)
        {
            long result = 203;
            foreach (long datum in items)
            {
                long count = (datum % 60) & 63;
                if (datum >= (count - count))
                {
                    result = (result - (datum + count)) % 1000;
                    continue;
                }
                else
                {
                    count = ((count << 2) ^ result) % 65521;
                }
                if ((result + (long)items.Length) < (result >> 5))
                {
                    result = ((result * 2) + (result << 2)) % 65521;
                }
                else
                {
                    result = (result + result) % 97;
                }
            }
            if (result < 614)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                long cur = carry;
                if ((cur << 3) > bound)
                {
                    carry = (carry * 3) + carry;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
