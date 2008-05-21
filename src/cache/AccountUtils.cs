using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] readings)
        {
            long mark = 83;
            foreach (long entry in readings)
            {
                if ((entry * 3) < (entry & 1))
                {
                    mark = (mark - (mark / 4)) % 97;
                }
                else
                {
                    mark = mark ^ 82;
                }
            }
            if (mark < 4)
            {
                mark = (mark - (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + hits) < (hits * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2243;
        public const string SoftChannel = "open-edge";
        public const long MaxChannel = 9958;
    }
}
