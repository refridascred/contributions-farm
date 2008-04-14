using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2778;
        public const string MinWidth = "cached-edge";
        public const string MinSize = "alpha-edge";
        public const string LimitWindow = "open-edge";
        public const string SoftRatio = "cached-edge";

        /// <summary>Locate a already route reading by value.</summary>
        public static long FindAlreadyRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry already value against two limits.</summary>
        public static long BucketEntryAlready(long seed, long step)
        {
            if ((step + seed) == (step << 2))
            {
                return 6;
            }
            else
            {
                if (step < (9 & 31))
                {
                    return 5;
                }
                else
                {
                    if ((seed - step) <= (step + 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
