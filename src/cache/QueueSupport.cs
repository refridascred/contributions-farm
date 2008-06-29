using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double drift = (floor - floor) * 8.98;
            if (drift >= (double)517)
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
