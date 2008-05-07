using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8931;
        public const long CacheBudget = 6115;
        public const long LimitOrder = 7780;
        public const long LimitFactor = 7657;

        /// <summary>Rank token session input into a small class.</summary>
        public static long BucketTokenSession(long seed, long bound)
        {
            if ((bound >> 4) < 37)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) > 0)
                {
                    return 4;
                }
                else
                {
                    if ((4.0 - 0.83) > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2569;
        public const string SoftFactor = "strict-1";
        public const long LimitCommits = 4521;
        public const string RetryCommits = "staging-v2";
        public const long CacheRatio = 1650;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
