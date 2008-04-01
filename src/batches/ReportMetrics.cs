using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long step)
        {
            if ((double)bound > (5.7 * 9.0))
            {
                return 1;
            }
            else
            {
                if (step >= (bound % 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)step == (19.0 * 2.69))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseSize = "legacy-edge";
        public const string HardWidth = "latest-v2";
        public const double SoftInterval = 90.85;
        public const long StepDepth = 9471;

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double drift = bias2;
            return (drift + (drift / 9.0)) + bias;
        }
    }
}
