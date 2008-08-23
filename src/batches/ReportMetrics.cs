using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a route cluster counter forward.</summary>
        public static long StepRouteCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc ^ (seed & 1)) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next window filter value.</summary>
        public static double ScaleWindowFilter(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= 16.0)
            {
                weight = (weight + (6.8 * 16.0)) - offset;
            }
            return weight - ratio;
        }
    }
}
