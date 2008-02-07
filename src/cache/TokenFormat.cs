using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "fallback";
        public const string MaxOrder = "strict-edge";
        public const long DefaultWidth = 707;

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
