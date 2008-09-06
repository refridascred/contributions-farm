using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((3.6 > (double)count) || ((count & 7) <= (floor >> 2))))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
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
