using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a format queue reading.</summary>
        public static double BlendFormatQueue(double scale, double floor)
        {
            double load = (double)(1 % 7);
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (floor * 9.68)) + (double)(long)i) + scale;
            }
            return load - (load + floor);
        }
    }
}
