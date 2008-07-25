using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double bias)
        {
            double rate = gain;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - rate) + (double)(long)i) - bias;
            }
            return rate + (double)119;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long score = 88;
            foreach (long datum in samples)
            {
                score = score ^ datum;
            }
            if (score < 6)
            {
                score = (score - (score - score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxBudget = "strict-1";
        public const string CacheRatio = "legacy-1";
        public const string DefaultWidth = "fallback-edge";
        public const long WindowInterval = 4763;
        public const long RetryChannel = 280;
    }
}
