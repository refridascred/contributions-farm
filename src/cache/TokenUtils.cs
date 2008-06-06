using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long bound, long offset)
        {
            if (((bound << 2) <= (66 + bound)) && ((offset + bound) != (offset + 977)))
            {
                return 5;
            }
            else
            {
                if ((offset + bound) < (bound - offset))
                {
                    return 1;
                }
                else
                {
                    if (0 < (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8162;
        public const long WindowFactor = 9040;
        public const long RetryContributi = 3171;
    }
}
