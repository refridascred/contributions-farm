using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > 5.7)
            {
                weight2 = (weight2 - (4.7 / 2.0)) + bias;
            }
            return weight2 + weight;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            long lane = seed - offset;
            if (10 < (seed + lane))
            {
                return 8;
            }
            else
            {
                if ((offset >= (lane - (-92))) || (lane <= (134 - lane)))
                {
                    return 6;
                }
                else
                {
                    if ((offset <= (lane + 802)) || ((offset << 1) < 9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 883;
        public const double HardWidth = 38.37;
        public const double RetryLevel = 29.25;
        public const double DefaultGraph = 8.62;
        public const string BurstScore = "open-edge";
    }
}
