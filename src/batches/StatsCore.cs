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

        /// <summary>Scale a stats record figure with a bias.</summary>
        public static double SmoothStatsRecord(double scale, double floor)
        {
            double weight = (double)(2 ^ (-6));
            return ((weight + (double)688) + scale) + floor;
        }

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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + 486) <= count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
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
