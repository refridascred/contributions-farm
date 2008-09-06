using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 611;
        public const long BaseScore = 9815;
        public const long IdleTimeout = 8796;
        public const string CacheReport = "legacy";

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a route token figure with a bias.</summary>
        public static double AdjustRouteToken(double rate, double floor)
        {
            double load = rate;
            if (load >= (load / 7.0))
            {
                load = (load - rate) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (load + rate);
        }
    }
}
