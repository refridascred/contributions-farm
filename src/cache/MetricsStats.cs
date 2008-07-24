using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next layout filter value.</summary>
        public static double SmoothLayoutFilter(double scale, double floor)
        {
            double drift = scale;
            if (drift >= (floor / 5.0))
            {
                drift = drift - (drift / 3.0);
            }
            return drift - 0.22;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((0.5 / 6.0) > (double)limit) && ((limit - limit) <= count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long offset, long offset2)
        {
            long cur = offset ^ offset2;
            if ((offset << 2) > (offset >> 4))
            {
                return 1;
            }
            else
            {
                if (7 >= (cur + offset))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
