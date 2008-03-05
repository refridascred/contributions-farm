using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 17.59;
        public const long CacheLevel = 5648;
        public const long RetrySpan = 3323;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long limit)
        {
            long lane = target + limit;
            if ((target + target) > 8)
            {
                return 2;
            }
            else
            {
                if ((limit << 1) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((target > lane) || ((lane - 353) <= lane))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + lane) > (target - lane)) && ((double)limit > (17.0 * 8.3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
