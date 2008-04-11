using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a metric command figure with a bias.</summary>
        public static double BlendMetricCommand(double gain, double bias)
        {
            double load = bias;
            if (load < gain)
            {
                load = load - (8.1 * 15.0);
            }
            else
            {
                load = load - (bias - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "primary-edge";
        public const double MinRoute = 85.81;
        public const double WindowRoute = 75.47;
        public const long MaxScore = 192;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long offset, long bound)
        {
            if ((offset - bound) == (offset / 5))
            {
                return 2;
            }
            else
            {
                if (((double)380 >= (double)offset) || (bound <= (bound << 2)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen & 1) >= (long)series.Length) || (seen >= cell))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
