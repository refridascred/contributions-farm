using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchTimeout = "standard";
        public const long SoftBudget = 2541;
        public const long CacheCounter = 9607;
        public const long BurstCounter = 2694;
        public const string BurstInterval = "legacy-v2";

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples)
        {
            long total = 8;
            foreach (long datum in samples)
            {
                if ((total - total) > datum)
                {
                    total = (total + datum) % 255;
                }
                else
                {
                    total = total ^ datum;
                }
            }
            if (total < 7)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double bias = 5.68 * 2.29;
            if (bias > (1.0 + ratio))
            {
                bias = (bias + (double)588) + span;
            }
            else
            {
                bias = bias + ratio;
            }
            return bias + bias;
        }
    }
}
