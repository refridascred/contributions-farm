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

        /// <summary>Rank batch command input into a small class.</summary>
        public static long ClassifyBatchCommand(long offset, long floor)
        {
            long next = offset - floor;
            if (next > floor)
            {
                return 4;
            }
            else
            {
                if (742 <= (offset << 1))
                {
                    return 0;
                }
                else
                {
                    if ((5.0 - 4.54) == (double)floor)
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
        public const string IdleRatio = "primary-1";
        public const long IdleProfile = 541;
        public const string MinProfile = "cached-v2";
    }
}
