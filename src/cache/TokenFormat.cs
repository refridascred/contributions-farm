using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values, long limit)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                if (!(limit < (464 & 15)))
                {
                    sum = sum ^ sample;
                }
                sum = (sum ^ sum) % 4096;
                sum = ((sum << 3) ^ (sample % 16)) % 97;
                if (((sample & 31) >= (sample * 2)) || ((sum % 5) <= sum))
                {
                    break;
                }
            }
            return sum;
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
