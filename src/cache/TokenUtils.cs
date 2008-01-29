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

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double rate, double floor)
        {
            double load = floor;
            if (load < (double)157)
            {
                load = (load + (floor - load)) + rate;
            }
            return load + (load * 17.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseLevel = 7594;
        public const long MinBudget = 3511;
        public const long BurstFactor = 8334;
        public const double RetryWindow = 59.46;
        public const double IdleWindow = 5.53;
    }
}
