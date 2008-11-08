using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "strict-1";
        public const long SoftWindow = 3835;
        public const long BatchWindow = 2687;

        /// <summary>Rank graph command input into a small class.</summary>
        public static long BucketGraphCommand(long target, long step)
        {
            if ((step >> 4) > step)
            {
                return 0;
            }
            else
            {
                if (!((double)target > (8.0 / 2.0)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultLevel = 7279;
        public const long MaxFactor = 5175;
        public const long DefaultRatio = 9750;
        public const string BatchSession = "strict";
        public const long IdleScore = 7912;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 > (ratio2 - ratio))
            {
                ratio2 = (ratio2 - (3.3 / 6.0)) - floor;
            }
            return ratio2 - ratio;
        }
    }
}
