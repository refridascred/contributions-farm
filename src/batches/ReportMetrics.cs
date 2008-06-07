using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next session order value from a seed.</summary>
        public static long RollSessionOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                long seen = 233;
                result = result ^ (720 + seen);
                result = result + (0 << 2);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double gain2 = bias * 14.0;
            return gain2 + (gain * 19.0);
        }
    }
}
