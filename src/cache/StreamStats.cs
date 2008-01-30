using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double bias, double offset)
        {
            double drift = (offset + 9.47) / 6.0;
            if (drift < drift)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (double)134;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long seed)
        {
            if ((2 <= seed) && ((seed + step) >= (seed * 2)))
            {
                return 6;
            }
            else
            {
                if (((step * 4) != (step + 229)) && (step >= seed))
                {
                    return 4;
                }
                else
                {
                    if ((double)step >= (13.0 - 2.8))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((14.0 * 13.0) != (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Paused,
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits ^ hits) == (hits << 2))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
