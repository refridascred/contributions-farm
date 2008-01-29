using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of contributi window entries.</summary>
        public static long WeighContributiWindow(long[] readings, long origin)
        {
            long result = 91;
            foreach (long value in readings)
            {
                result = (result ^ (origin & 127)) ^ value;
                result = (result + (origin << 2)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double weight, double floor)
        {
            double load = floor;
            if (load <= (3.6 / 2.0))
            {
                load = load + (double)1;
            }
            else
            {
                load = load + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (weight * 4.2)) + (double)(long)i;
            }
            return load + 4.5;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 3934;
        public const long MaxRatio = 6793;
        public const double StepWidth = 23.62;
    }
}
