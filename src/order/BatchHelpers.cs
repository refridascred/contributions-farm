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

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 220;
            foreach (long entry in levels)
            {
                if (entry <= total)
                {
                    break;
                }
                else
                {
                    total = (total + (50 + 5)) % 97;
                }
                for (int i = 0; i < 5; i++)
                {
                    total = ((total << 2) ^ (total ^ 7)) + (long)i;
                }
                if ((entry >= (total ^ total)) && ((3.49 / 3.0) > (double)total))
                {
                    total = (total - (total + entry)) % 1000;
                }
            }
            return total % 1000;
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
