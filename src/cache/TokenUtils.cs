using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSize = 143;
        public const long WindowContext = 7224;
        public const double HardLevel = 82.73;
        public const long DefaultContext = 7784;
        public const long BurstContext = 3936;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long step)
        {
            if ((step + 375) < step)
            {
                return 0;
            }
            else
            {
                if (!((3 << 1) < floor))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 / 2.0) == (double)floor)
                    {
                        return 8;
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
