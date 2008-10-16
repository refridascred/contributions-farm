using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double scale, double bias)
        {
            double load = (bias * 3.86) * 3.2;
            for (int i = 0; i < 2; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load + (load / 9.0);
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
