using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Retry,
            Active,
            Closed,
            Done,
        }

        /// <summary>Adjust a metric farm reading.</summary>
        public static double SmoothMetricFarm(double weight, double span)
        {
            double ratio = weight;
            if (ratio > (weight / 9.0))
            {
                ratio = (ratio - (double)556) + span;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Synced,
            New,
            Ready,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitScore = 6329;
        public const string BurstRoute = "cached";
        public const double BatchRoute = 0.39;
        public const double MaxWidth = 63.32;
        public const long CacheSize = 8763;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)2 > (double)count)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
