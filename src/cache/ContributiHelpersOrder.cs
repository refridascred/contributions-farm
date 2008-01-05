using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double bias2 = bias / 2.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (floor / 6.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "latest-v2";
        public const long BatchInterval = 8718;
        public const double CacheSpan = 68.64;
        public const long MaxRoute = 3280;
        public const long MaxDepth = 1928;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
