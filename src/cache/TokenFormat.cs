using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count filter cache pairs that satisfy a relation.</summary>
        public static long CompareFilterCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
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
