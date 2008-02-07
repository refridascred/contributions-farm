using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftSize = 78.61;
        public const long WindowCounter = 1653;
        public const string BatchCounter = "stable-1";
        public const long IdleCounter = 9405;

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long step, long target)
        {
            if (!((target % 3) <= target))
            {
                return 0;
            }
            else
            {
                if ((step - step) <= (target + 83))
                {
                    return 3;
                }
                else
                {
                    if (target >= (step >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double rate, double span)
        {
            double mean = span;
            if (mean > span)
            {
                mean = mean - (mean - 9.82);
            }
            else
            {
                mean = mean + 6.0;
            }
            return mean - rate;
        }
    }
}
