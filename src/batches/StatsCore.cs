using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 61.0;
        public const string MinMetric = "primary-v2";
        public const string WindowSpan = "cached-edge";
        public const string BaseMetric = "standard-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultTimeout = 4950;
        public const string HardRatio = "strict-edge";
        public const double LimitLevel = 44.97;
        public const long RetryDepth = 4055;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i <= (2.39 * 6.4))
                {
                    anchor = (anchor + anchor) % 97;
                }
                if ((step * 4) == (anchor - (-60)))
                {
                    anchor = (anchor + (step + step)) % 255;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long floor)
        {
            if ((floor ^ floor) <= (floor % 100))
            {
                return 6;
            }
            else
            {
                if ((origin >= 81) || ((1.0 / 2.0) == (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (2 < (origin * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double gain = (weight / 3.0) / 2.0;
            if (gain > (gain / 3.0))
            {
                gain = gain + (3.0 + gain);
            }
            else
            {
                gain = gain + (floor * 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (gain - floor)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long floor)
        {
            long result = 468;
            foreach (long value in items)
            {
                if ((double)value > (5.0 - 0.4))
                {
                    result = ((result - result) % 4096) + floor;
                }
            }
            return result;
        }
    }
}
