using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseInterval = "legacy-v2";
        public const long DefaultMetrics = 3312;
        public const double WindowLevel = 50.81;
        public const long IdleMetrics = 9560;
        public const double RetryMetrics = 76.14;

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long bound, long target)
        {
            if ((target + target) > (8 % 3))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) > (bound & 63)) || ((bound / 9) != (394 ^ bound)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long floor)
        {
            if (floor <= (6 ^ floor))
            {
                return 7;
            }
            else
            {
                if ((floor / 2) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound + floor) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
