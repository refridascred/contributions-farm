using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9555;
        public const double WindowChecks = 13.66;
        public const long MaxFactor = 7526;

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
