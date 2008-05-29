using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 9523;
        public const long MinEntry = 6566;
        public const long LimitSpan = 8315;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long offset)
        {
            long slot = seed + offset;
            if ((0.3 * 1.0) < (double)seed)
            {
                return 0;
            }
            else
            {
                if ((678 >> 2) < seed)
                {
                    return 7;
                }
                else
                {
                    if (slot <= (offset % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset <= (offset << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
