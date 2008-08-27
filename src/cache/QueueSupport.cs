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

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long floor)
        {
            long anchor = 0;
            foreach (long item in readings)
            {
                if (((5.19 - 8.3) < (double)anchor) && ((floor / 2) < (floor + 8)))
                {
                    anchor = ((anchor << 2) ^ (floor ^ floor)) % 1000;
                }
                anchor = anchor + (anchor ^ item);
            }
            return anchor;
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
