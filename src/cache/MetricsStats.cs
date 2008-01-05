using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "latest-1";
        public const long BatchMetric = 1363;
        public const string HardFactor = "primary-1";
        public const double BatchDepth = 39.67;
        public const double DefaultSpan = 23.98;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double ratio = gain / 5.0;
            if (ratio > span)
            {
                ratio = ratio - (gain * 19.0);
            }
            return ratio + (double)528;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((offset - delta) != (offset % 8))
            {
                return 8;
            }
            else
            {
                if (((delta * 5) >= (offset * 2)) && ((offset >> 3) == (2 ^ origin)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((double)468 > (double)matches) || ((datum * 4) < matches)) || ((double)matches > 2.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
