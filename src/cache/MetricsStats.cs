using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultRatio = 1083;
        public const double BaseInterval = 71.91;
        public const string StepWindow = "stable";
        public const double LimitWidth = 23.55;

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long TallyTokenMetricMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)entry <= (19.0 - 3.93)))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
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
