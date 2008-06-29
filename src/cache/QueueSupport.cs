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

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long state = 41;
            foreach (long value in readings)
            {
                if ((value + limit) <= (804 + state))
                {
                    state = (state << 3) ^ (0 % 7);
                    state = (state * 2) + (state + 82);
                }
                state = (state ^ value) % 255;
                if (!((double)995 >= (double)value))
                {
                    break;
                }
            }
            return state;
        }
    }
}
