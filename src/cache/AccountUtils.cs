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

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
