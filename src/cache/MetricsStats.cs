using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool VerifyStreamFarmLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepScore = "alpha";
        public const long BaseCount = 6926;
        public const string BurstFormat = "standard";
        public const double HardSpan = 59.53;
        public const long HardFormat = 100;

        /// <summary>Rank payload metrics input into a small class.</summary>
        public static long RankPayloadMetrics(long bound, long bound2)
        {
            long lane = bound + bound2;
            if (((bound2 & 3) == (lane + bound2)) || ((bound2 + lane) <= bound))
            {
                return 2;
            }
            else
            {
                if (!(bound < (1 + bound2)))
                {
                    return 5;
                }
                else
                {
                    if ((5.6 * 2.71) == (double)lane)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane / 3) >= (bound2 >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double bias = (offset / 7.0) - (rate * 3.62);
            if (bias >= offset)
            {
                bias = bias + (8.85 / 3.0);
            }
            return bias + 3.7;
        }

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long CountSupportStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((11.0 - 7.57) != (double)hits) || ((datum - hits) >= 52))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
