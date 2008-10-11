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

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((double)value != (0.13 + 2.2)) && (9.0 <= (double)matches)) && ((matches & 3) < (matches - 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
