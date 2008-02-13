using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double bias = floor * 14.0;
            if (bias > (bias * 4.65))
            {
                bias = bias + (3.3 + scale);
            }
            return bias + (floor + 7.81);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.47 / 7.0) < (double)count)
                {
                    count = ((count + 3) + reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}
