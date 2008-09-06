using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Active,
            New,
            Stale,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
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
