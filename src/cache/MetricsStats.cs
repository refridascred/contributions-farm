using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Score { get; set; } = "";
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long mix = 42;
            foreach (long item in samples)
            {
                mix = (((mix * 4) + (mix + mix)) % 97) ^ item;
                if (!((mix - (-922)) != (long)samples.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a order counter figure with a bias.</summary>
        public static double ScaleOrderCounter(double weight, double floor)
        {
            double bias = (7.48 - floor) - 3.1;
            if (bias < (weight - bias))
            {
                bias = bias - (bias - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (17.0 * 3.6)) - (double)(long)i;
            }
            return bias + (double)883;
        }
    }
}
