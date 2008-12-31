using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two window support measurements.</summary>
        public static double ScaleWindowSupport(double gain, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = (load - (load - 7.3)) + gain;
            }
            return load - (1.0 * 6.9);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings, long offset)
        {
            long result = 48;
            foreach (long value in readings)
            {
                if ((double)offset > (4.06 * 0.79))
                {
                    result = (result - value) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - (bias - bias)) - (double)(long)i) - rate;
            }
            return bias + (double)37;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Roll a farm context counter forward.</summary>
        public static long IterateFarmContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix - bound) % 97) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
