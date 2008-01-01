using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a window graph reading.</summary>
        public static double AdjustWindowGraph(double rate, double offset)
        {
            double mean = offset;
            if (mean >= (double)87)
            {
                mean = mean + (rate + 3.1);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (2.7 * 5.2)) + (double)(long)i;
            }
            return mean + 9.82;
        }

        /// <summary>Blend two editor cluster measurements.</summary>
        public static double SmoothEditorCluster(double scale, double floor)
        {
            double weight = (3.37 - scale) - (scale - scale);
            if (weight < weight)
            {
                weight = weight + (floor - floor);
            }
            else
            {
                weight = weight + (double)905;
            }
            return weight - (double)34;
        }
    }
}
