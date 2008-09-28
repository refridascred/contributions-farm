using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a layout metric pair into a bucket.</summary>
        public static long RankLayoutMetric(long offset, long step)
        {
            if (step < (step % 24))
            {
                return 7;
            }
            else
            {
                if ((9.46 - 6.8) >= (double)step)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
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

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
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
