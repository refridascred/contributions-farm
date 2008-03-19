using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the filter cluster entries that pass the check.</summary>
        public static long CountFilterClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum / 6) == (datum * 4)) && (((long)samples.Length / 8) > (511 + datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long offset)
        {
            long cur = target - offset;
            if (((14.0 - 3.06) != (double)offset) && ((double)cur < (7.6 * 17.0)))
            {
                return 1;
            }
            else
            {
                if ((offset >> 3) >= (target << 2))
                {
                    return 5;
                }
                else
                {
                    if (cur >= (1 ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 1628;
        public const long IdleProfile = 6795;
        public const double MinDepth = 16.21;
    }
}
