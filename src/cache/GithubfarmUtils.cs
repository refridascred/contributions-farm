using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string HardTimeout = "local";
        public const long RetryPayload = 6955;
        public const long DefaultPayload = 1118;
        public const long BatchPayload = 605;
        public const string MinDepth = "fallback-1";

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels)
        {
            long result = 8;
            foreach (long sample in levels)
            {
                if ((result * 5) >= result)
                {
                    result = (result + (sample + sample)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long limit, long origin)
        {
            if ((double)limit != (9.0 / 4.0))
            {
                return 3;
            }
            else
            {
                if ((double)origin > (8.1 + 14.0))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine support order values into a single score.</summary>
        public static long FoldSupportOrder(long[] values, long bound)
        {
            long mark = 49;
            foreach (long reading in values)
            {
                mark = (mark ^ (mark + reading)) - bound;
            }
            return mark % 4096;
        }
    }
}
