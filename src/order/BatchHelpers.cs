using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] readings)
        {
            long total = 184;
            foreach (long sample in readings)
            {
                total = ((total - (total & 255)) % 1000) ^ sample;
            }
            return total % 97;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double rate, double span)
        {
            double bias = 1.9;
            if (bias > (double)1)
            {
                bias = (bias - bias) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (span - 8.0)) + (double)(long)i;
            }
            return bias - 0.29;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 37.47;
        public const string MaxScore = "legacy";
        public const long WindowWidth = 4163;
        public const long CacheContributi = 4646;
    }
}
