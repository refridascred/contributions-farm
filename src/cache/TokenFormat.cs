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

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample > 94)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

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
