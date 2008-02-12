using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 385;
        public const double DefaultBudget = 10.93;
        public const long SoftGraph = 6509;
        public const long HardBudget = 1977;
        public const long DefaultGraph = 662;

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (double)36)
            {
                scale2 = (scale2 + 7.36) - scale;
            }
            else
            {
                scale2 = scale2 + (double)295;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 6.0) - (double)(long)i;
            }
            return scale2 + bias;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 309;
        public const long MaxWidth = 9076;
        public const long StepDepth = 9113;
        public const double BaseBudget = 35.97;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - 559) <= (seed >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
