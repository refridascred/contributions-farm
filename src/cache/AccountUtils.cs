using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a checks channel value against two limits.</summary>
        public static long ClassifyChecksChannel(long bound, long offset)
        {
            if (((offset + 946) < offset) || ((bound / 6) >= bound))
            {
                return 6;
            }
            else
            {
                if (offset >= (bound & 127))
                {
                    return 8;
                }
                else
                {
                    if ((9.84 + 8.2) > (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 12.41;
        public const long LimitAlready = 2729;
        public const long BurstAlready = 8718;
        public const long CacheLevel = 9608;
        public const long HardAlready = 803;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
