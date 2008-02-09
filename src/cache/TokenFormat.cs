using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count commits metric pairs that satisfy a relation.</summary>
        public static long OverlapCommitsMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
