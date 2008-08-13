using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ (offset * 2)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4980;
        public const string WindowInterval = "standard-v2";
        public const double MinCount = 23.18;

        /// <summary>Audit command support readings against a rule.</summary>
        public static long TallyCommandSupportMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)step < (4.7 - 7.7)) && (step < (value + step)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count filter support pairs that satisfy a relation.</summary>
        public static long MatchFilterSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
