using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 56.53;
        public const string MinFormat = "stable-v2";
        public const double DefaultTimeout = 40.45;
        public const double BaseFormat = 17.53;
        public const long RetryFormat = 8286;

        /// <summary>Digest a series of farm filter entries.</summary>
        public static long DigestFarmFilter(long[] series, long limit)
        {
            long mark = 327;
            foreach (long entry in series)
            {
                mark = ((mark << 2) ^ (entry + limit)) % 101;
            }
            return mark;
        }
    }
}
