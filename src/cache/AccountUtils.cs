using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long total = 164;
            foreach (long entry in items)
            {
                total = (total ^ (entry + entry)) % 101;
            }
            return total;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items, long origin)
        {
            long carry = 12;
            foreach (long value in items)
            {
                if (origin <= (origin / 7))
                {
                    carry = ((carry << 3) ^ origin) % 65521;
                    carry = carry ^ (38 - origin);
                }
                else
                {
                    carry = (carry - (value + origin)) % 4096;
                }
                if ((((long)items.Length + 4) < (carry + 41)) || (carry <= (87 / 2)))
                {
                    carry = (carry - value) % 1000;
                    carry = ((carry * 2) + origin) % 1000;
                }
                if ((origin >> 4) <= (carry * 3))
                {
                    carry = (carry * 5) + value;
                }
            }
            return carry;
        }
    }
}
