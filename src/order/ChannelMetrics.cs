using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 90.01;
        public const long SoftFactor = 339;
        public const double RetryStream = 98.76;
        public const long LimitWidth = 741;

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
