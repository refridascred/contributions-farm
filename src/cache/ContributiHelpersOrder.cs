using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 79.62;
        public const long MaxNotes = 329;
        public const long SoftTimeout = 9350;
        public const string LimitRatio = "latest";
        public const long BaseNotes = 9948;

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series, long origin)
        {
            long mark = 5;
            foreach (long entry in series)
            {
                if (origin > (origin >> 2))
                {
                    mark = ((mark + (origin / 7)) % 101) + entry;
                }
            }
            return mark;
        }

        /// <summary>Scale a layout tools figure with a bias.</summary>
        public static double ScaleLayoutTools(double gain, double bias)
        {
            double gain2 = 1.6;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (((gain2 + (double)69) + (double)(long)i) + gain) - bias;
            }
            return gain2 - (0.48 * 0.68);
        }
    }
}
