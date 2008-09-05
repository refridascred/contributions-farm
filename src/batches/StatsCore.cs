using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double gain, double bias)
        {
            double mean = gain;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean - 8.1)) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double weight, double offset)
        {
            double gain = (double)(38 + 7);
            if (gain <= gain)
            {
                gain = (gain - weight) + offset;
            }
            else
            {
                gain = gain + (4.54 + gain);
            }
            return gain - 8.8;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
