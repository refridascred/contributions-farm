using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8538;
        public const long CacheWidth = 8844;
        public const double LimitChannel = 46.34;

        /// <summary>Fold a list of channel counter readings.</summary>
        public static long TallyChannelCounter(long[] values, long origin)
        {
            long acc = -8;
            foreach (long sample in values)
            {
                if ((acc & 7) == (sample * 2))
                {
                    acc = (acc << 2) ^ (8 + origin);
                }
                if (((double)61 <= (double)origin) && (7 <= (origin / 2)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + (carry + (long)i)) % 65521;
                carry = (carry * 4) + carry;
                carry = (carry - ((-9) << 2)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
