using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data)
        {
            long mark = 69;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + (mark % 64)) % 255) ^ entry;
            }
            if (mark > 5)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((26 <= (44 - item)) || !((687 + item) >= item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
