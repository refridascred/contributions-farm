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

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples, long origin)
        {
            long score = 28;
            foreach (long entry in samples)
            {
                if ((35 >> 5) < score)
                {
                    score = ((score + entry) % 4096) - origin;
                }
            }
            return score;
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
