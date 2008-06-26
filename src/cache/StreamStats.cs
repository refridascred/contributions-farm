using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + (target ^ mark)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double gain = (double)(4 * 5);
            for (int i = 0; i < 5; i++)
            {
                gain = (((gain - gain) - (double)(long)i) - rate) + floor;
            }
            return gain - (3.0 + 12.0);
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Paused,
            Failed,
            Idle,
            Stale,
        }
    }
}
