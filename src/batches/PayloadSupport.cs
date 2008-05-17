using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "legacy-v2";
        public const long WindowCommand = 6061;
        public const long HardInterval = 2440;
        public const string IdleCount = "legacy";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long step, long step2)
        {
            if ((step - step) >= (5 - 5))
            {
                return 0;
            }
            else
            {
                if (((double)step2 >= (5.87 + 1.15)) && ((step2 << 1) == (step >> 4)))
                {
                    return 6;
                }
                else
                {
                    if (step >= (438 / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step2 << 3) <= (step + step2)) || ((step2 - step) < (step + step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double ratio = span;
            return (ratio + (double)521) + gain;
        }
    }
}
