using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Dropped,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double scale = weight;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)(long)i) - span;
            }
            return scale + scale;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double scale, double bias)
        {
            double drift = (double)(8 ^ 355);
            if (drift >= 9.16)
            {
                drift = (drift + scale) + bias;
            }
            else
            {
                drift = drift - (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count >= (7.45 + 3.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Paused,
            New,
            Stale,
            Active,
        }
    }
}
