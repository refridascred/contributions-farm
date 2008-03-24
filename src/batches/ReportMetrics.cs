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

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double drift = (bias / 8.0) + (6.64 + bias);
            if (drift < (double)24)
            {
                drift = drift + 6.9;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + (double)4;
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
