using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 7272;
        public const string BatchStats = "legacy-1";
        public const long RetrySpan = 4903;
        public const long DefaultBudget = 1528;
        public const string MaxStats = "stable";

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc - (offset + (long)i)) % 255;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (acc ^ acc) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double mean = 4.0;
            if (mean > (15.0 * 0.9))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (floor - gain);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (2.8 * 3.3);
        }
    }
}
