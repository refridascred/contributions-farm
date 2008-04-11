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

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long seed, long floor)
        {
            if (((seed + seed) != (floor * 3)) && (2 > seed))
            {
                return 4;
            }
            else
            {
                if ((17.0 / 8.0) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (!((5.1 / 8.0) != (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
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
