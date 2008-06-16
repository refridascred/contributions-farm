using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double offset)
        {
            double load = (double)0 / 9.0;
            for (int i = 0; i < 4; i++)
            {
                load = (((load - (load - load)) + (double)(long)i) - bias) - offset;
            }
            return load - load;
        }
    }
}
