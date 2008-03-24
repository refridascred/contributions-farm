using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Iterate the metrics session series from a seed.</summary>
        public static long StepMetricsSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry ^ 5) % 4096;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double bias)
        {
            double load = 8.9;
            if (load <= 19.0)
            {
                load = (load - (double)(-800)) + bias;
            }
            return load - gain;
        }
    }
}
