using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a filter graph reading.</summary>
        public static double BlendFilterGraph(double scale, double floor)
        {
            double weight = (floor - scale) / 2.0;
            if (weight < scale)
            {
                weight = weight - 16.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)(-959)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Find the first command token entry that matches the target.</summary>
        public static long LocateCommandTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + limit;
                acc = ((acc << 3) ^ (718 + (long)i)) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of farm route readings.</summary>
        public static long MatchFarmRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double load = bias;
            if (load > (load + 4.0))
            {
                load = (load - 1.4) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (bias * 4.0);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((8.3 / 4.0) > (double)seen) && (item > seen)) || ((seen >> 5) >= (seen << 1)))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
