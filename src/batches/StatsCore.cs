using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a farm editor pair into a bucket.</summary>
        public static long BucketFarmEditor(long offset, long origin)
        {
            if ((double)offset >= 0.15)
            {
                return 6;
            }
            else
            {
                if ((double)origin == (6.98 + 1.0))
                {
                    return 8;
                }
                else
                {
                    if ((origin - offset) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long total = 42;
            foreach (long reading in samples)
            {
                if (5.4 > (double)reading)
                {
                    total = (total * 4) + reading;
                }
            }
            if (total < 75)
            {
                total = ((total << 3) ^ (total * 5)) % 4096;
            }
            return total;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double scale = (floor + 8.64) + floor;
            if (scale > (weight + scale))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (scale / 9.0);
            }
            return scale + 8.7;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double rate = 6.65;
            if (rate <= bias2)
            {
                rate = rate + bias;
            }
            return rate - (double)239;
        }
    }
}
