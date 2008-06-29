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

        /// <summary>Validate stream support readings against a bound.</summary>
        public static bool GuardStreamSupportBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
