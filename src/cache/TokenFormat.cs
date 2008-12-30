using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up window checks samples.</summary>
        public static long MatchWindowChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                if ((mark << 3) == (mark / 4))
                {
                    mark = ((mark << 2) ^ (item - item)) % 4096;
                }
                else
                {
                    mark = (mark - (item % 100)) % 65521;
                }
                if (((double)mark >= (2.5 + 5.23)) && ((item >> 5) > 6))
                {
                    break;
                }
            }
            if (mark < (-14))
            {
                mark = ((mark * 2) + (mark + mark)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long DeriveContributiFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((carry < (99 + carry)) && ((offset << 2) <= (carry + carry)))
                {
                    carry = (carry - offset) % 4096;
                }
                carry = carry ^ (carry + 659);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
