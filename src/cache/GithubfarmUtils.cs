using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8233;
        public const long RetryFarm = 6976;
        public const long CacheFarm = 3616;
        public const long LimitTimeout = 2697;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 86.79;
        public const long DefaultChannel = 5155;
        public const double CacheChannel = 5.75;
        public const long WindowSpan = 3442;
        public const long IdleChannel = 905;
    }
}
