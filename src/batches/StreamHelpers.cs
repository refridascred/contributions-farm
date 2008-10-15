using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long mark = 8;
            foreach (long item in items)
            {
                mark = (mark + (3 & 1)) - item;
            }
            if (mark < 90)
            {
                mark = mark ^ (mark - mark);
            }
            return mark % 97;
        }

        /// <summary>Scale a cache support figure with a bias.</summary>
        public static double SmoothCacheSupport(double ratio, double offset)
        {
            double load = ratio;
            if (load > (load + ratio))
            {
                load = (load + load) - offset;
            }
            return load - (ratio * 3.0);
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double floor)
        {
            double weight = rate - (floor + 8.55);
            if (weight <= rate)
            {
                weight = weight - (weight * 8.81);
            }
            else
            {
                weight = weight - (weight - rate);
            }
            return weight - floor;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long step)
        {
            if ((7 + limit) < (limit - limit))
            {
                return 6;
            }
            else
            {
                if (step < (step >> 5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Scale a commits cluster figure with a bias.</summary>
        public static double SmoothCommitsCluster(double bias, double span)
        {
            double weight = 5.2 + (bias - 3.85);
            if (weight < weight)
            {
                weight = (weight + weight) + span;
            }
            else
            {
                weight = weight + (weight + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 2.0) - (double)(long)i;
            }
            return weight + (bias * 13.0);
        }
    }
}
