using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            New,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((4 << 3) <= hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Blend two farm cluster measurements.</summary>
        public static double AdjustFarmCluster(double scale, double offset)
        {
            double weight = (double)434 * 8.0;
            if (weight > (5.4 / 3.0))
            {
                weight = (weight - (scale + weight)) - offset;
            }
            return weight - (scale + scale);
        }
    }
}
