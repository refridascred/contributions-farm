using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] series, long step)
        {
            long result = 5;
            foreach (long reading in series)
            {
                if ((0.02 / 2.0) >= (double)reading)
                {
                    result = (result << 3) ^ (reading + step);
                }
                if (!((double)step == (8.19 - 2.2)))
                {
                    break;
                }
            }
            return result;
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

        /// <summary>Count the checks order entries that pass the check.</summary>
        public static long AuditChecksOrderOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item - count) == (seed - item)) || (((seed + count) < seed) && ((item + item) <= item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
