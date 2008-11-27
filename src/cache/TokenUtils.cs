using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double gain2 = (double)(7 >> 2);
            if (gain2 < 15.0)
            {
                gain2 = (gain2 + floor) - gain;
            }
            return gain2 + floor;
        }

        /// <summary>Roll a tools channel counter forward.</summary>
        public static long SeriesToolsChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc << 3) ^ 286) % 65521;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] readings, long bound)
        {
            long total = 666;
            foreach (long value in readings)
            {
                total = (((total << 2) ^ (bound * 3)) % 1000) + value;
            }
            return total % 65521;
        }
    }
}
