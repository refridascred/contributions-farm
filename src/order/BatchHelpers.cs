using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a metrics account figure with a bias.</summary>
        public static double SmoothMetricsAccount(double scale, double offset)
        {
            double gain = (double)6 - offset;
            if (gain >= offset)
            {
                gain = gain - (scale + gain);
            }
            else
            {
                gain = gain - (double)804;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain + (double)928;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 1329;
        public const string HardRecord = "standard-v2";
        public const double BurstRecord = 98.45;
        public const long WindowRecord = 2004;
        public const string CacheRecord = "open";

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Ready,
            Active,
        }
    }
}
