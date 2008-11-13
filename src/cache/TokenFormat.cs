using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank token tools input into a small class.</summary>
        public static long ClassifyTokenTools(long offset, long bound)
        {
            if ((offset + offset) >= bound)
            {
                return 5;
            }
            else
            {
                if (((double)(-54) <= (double)offset) || ((bound + bound) == (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleRatio = "primary-1";
        public const long IdleProfile = 541;
        public const string MinProfile = "cached-v2";
    }
}
