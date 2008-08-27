using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = (result - (result << 2)) % 1000;
                if (seed <= ((long)i / 8))
                {
                    result = result + 7;
                    result = (result ^ (seed / 9)) % 1000;
                }
                if (seed <= (result - seed))
                {
                    result = (result ^ (result >> 4)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
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
