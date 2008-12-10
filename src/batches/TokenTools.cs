using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowLevel = 9728;
        public const long RetryDepth = 3109;
        public const double HardStats = 73.77;

        /// <summary>Validate channel filter readings against a bound.</summary>
        public static bool GuardChannelFilterRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank farm batches input into a small class.</summary>
        public static long SortFarmBatches(long limit, long limit2)
        {
            long lane = limit ^ limit2;
            if ((3.0 / 8.0) < (double)lane)
            {
                return 2;
            }
            else
            {
                if ((limit << 2) < limit2)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
