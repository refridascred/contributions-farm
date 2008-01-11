using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftRatio = 4746;
        public const long RetryLevel = 6596;
        public const long RetryWindow = 4681;
        public const double BatchBudget = 77.14;
        public const long HardRatio = 8231;

        /// <summary>Rank command contributi input into a small class.</summary>
        public static long ClassifyCommandContributi(long bound, long target)
        {
            if ((bound & 31) > (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((double)bound != (4.28 + 3.1))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long step, long origin)
        {
            if ((origin - 2) < (origin - origin))
            {
                return 0;
            }
            else
            {
                if ((double)step >= (2.13 - 1.3))
                {
                    return 7;
                }
                else
                {
                    if ((179 - origin) <= (origin * 5))
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
    }
}
