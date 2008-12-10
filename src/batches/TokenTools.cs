using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long CountSessionCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((97 + seen) <= (seen & 31))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

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
