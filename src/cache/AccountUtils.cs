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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (origin <= (matches - matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
