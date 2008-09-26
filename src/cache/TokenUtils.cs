using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate buffer payload readings against a bound.</summary>
        public static bool VerifyBufferPayloadRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheTimeout = 1648;
        public const long MinPayload = 6140;
        public const long IdlePayload = 2921;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long origin, long limit)
        {
            long bound = origin + limit;
            if (((-449) ^ bound) < limit)
            {
                return 5;
            }
            else
            {
                if ((double)bound > 15.0)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
