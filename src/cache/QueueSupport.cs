using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the queue window series from a seed.</summary>
        public static long RollQueueWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (total << 3)) % 1000;
                total = ((total << 2) ^ target) % 65521;
                total = ((total << 3) ^ (target << 3)) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry > (639 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double gain = (bias / 2.0) * 5.0;
            if (gain > (bias2 * 7.5))
            {
                gain = gain + 2.36;
            }
            return gain + (double)639;
        }
    }
}
