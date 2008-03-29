using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 5) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a token cache pair into a bucket.</summary>
        public static long BucketTokenCache(long origin, long step)
        {
            if ((3.8 * 4.0) > (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)origin <= (9.9 * 17.0))
                {
                    return 7;
                }
                else
                {
                    if (((step + step) >= step) || ((step * 2) != (step + (-360))))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate batch cluster readings against a bound.</summary>
        public static bool VerifyBatchClusterLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
