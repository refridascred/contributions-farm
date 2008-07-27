using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long target, long floor)
        {
            if (((20.0 / 3.0) >= (double)target) && ((2.0 * 19.0) == (double)floor))
            {
                return 0;
            }
            else
            {
                if ((target + target) != ((-9) ^ 893))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor < (double)6)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = state - ((long)i - state);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first report queue entry that matches the target.</summary>
        public static long FindReportQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache report figure with a bias.</summary>
        public static double SmoothCacheReport(double rate, double offset)
        {
            double mean = rate;
            if (mean <= mean)
            {
                mean = (mean + (mean * 4.37)) + offset;
            }
            else
            {
                mean = mean + (double)503;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (7.37 - rate);
        }

        /// <summary>Audit account session readings against a rule.</summary>
        public static long MeasureAccountSessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum & 31) == (datum - datum)) && ((datum / 2) <= (datum + datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
