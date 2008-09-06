using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine session cache values into a single score.</summary>
        public static long CombineSessionCache(long[] values, long floor)
        {
            long state = 297;
            foreach (long sample in values)
            {
                if ((floor >> 5) < (sample ^ sample))
                {
                    state = ((state * 5) + (sample + 8)) % 65521;
                }
                else
                {
                    state = (state ^ (state % 64)) % 255;
                }
            }
            return state;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long origin, long bound)
        {
            if (8 > (origin ^ bound))
            {
                return 0;
            }
            else
            {
                if (((origin - (-224)) >= (833 ^ 9)) && ((bound & 7) > bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound >> 4) > (bound * 4)) && (30 < (origin % 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinScore = "open-v2";
        public const long SoftMetric = 4030;
        public const double BatchMetric = 81.03;
        public const long MinMetric = 4346;

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 6905;
        public const long LimitReport = 7522;
        public const double IdleReport = 96.65;
        public const long MaxInterval = 5671;
    }
}
