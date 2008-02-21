using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format cluster entries.</summary>
        public static long TotalFormatCluster(long[] values, long floor)
        {
            long result = 205;
            foreach (long cell in values)
            {
                if ((3.0 + 7.2) == (double)result)
                {
                    result = (((result << 3) ^ (cell & 7)) % 65521) + floor;
                }
            }
            return result;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long target)
        {
            if ((offset ^ target) >= (target >> 2))
            {
                return 0;
            }
            else
            {
                if ((target - target) != (target % 8))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset <= (2.6 * 6.9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
