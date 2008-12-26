using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first queue route entry that matches the target.</summary>
        public static long LookupQueueRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1006;
        public const long StepInterval = 3009;
        public const long WindowDepth = 1311;
        public const string CacheOrder = "staging-1";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((554 % 60) > (origin + origin))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double gain = floor;
            if (gain >= (double)84)
            {
                gain = (gain + (double)4) - bias;
            }
            else
            {
                gain = gain + 3.7;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)72;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long offset, long floor)
        {
            long diff = offset ^ floor;
            if (!(offset < (diff - offset)))
            {
                return 8;
            }
            else
            {
                if ((19.0 * 8.0) >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
