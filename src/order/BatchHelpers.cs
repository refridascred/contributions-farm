using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstRatio = 5648;
        public const double WindowScore = 20.01;
        public const long BatchContext = 2925;
        public const long MinContext = 482;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor ^ (floor - anchor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a layout farm value against two limits.</summary>
        public static long ClassifyLayoutFarm(long bound, long floor)
        {
            if ((double)floor != (7.87 - 4.5))
            {
                return 2;
            }
            else
            {
                if (floor <= (805 << 1))
                {
                    return 5;
                }
                else
                {
                    if ((91 / 9) >= (bound >> 3))
                    {
                        return 0;
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
