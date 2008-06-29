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

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long target, long step)
        {
            if (((6.0 * 4.9) <= (0.4 * 0.6)) && ((target / 8) != (step - step)))
            {
                return 4;
            }
            else
            {
                if (step < (step + step))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
