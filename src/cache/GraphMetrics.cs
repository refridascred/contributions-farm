using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long limit)
        {
            if ((double)limit == (10.0 + 5.69))
            {
                return 0;
            }
            else
            {
                if ((29 & 127) < (limit ^ step))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)0 < (double)seed)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstInterval = 93.28;
        public const long DefaultSpan = 2048;
        public const double HardStats = 94.86;

        /// <summary>Find the first batch metrics entry that matches the target.</summary>
        public static long LookupBatchMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
