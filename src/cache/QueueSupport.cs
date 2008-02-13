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

        /// <summary>Digest a series of farm payload entries.</summary>
        public static long ScoreFarmPayload(long[] samples)
        {
            long state = 523;
            foreach (long reading in samples)
            {
                if ((reading >> 1) > (state % 5))
                {
                    state = (state * 2) + state;
                }
            }
            if (state > 76)
            {
                state = state ^ (state - state);
            }
            return state % 1000;
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
