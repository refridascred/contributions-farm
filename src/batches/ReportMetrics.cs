using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of session account readings.</summary>
        public static long MatchSessionAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 9208;
        public const string RetryBatch = "open-v2";
        public const string MinBatch = "cached-v2";

        /// <summary>Blend two queue tools measurements.</summary>
        public static double BlendQueueTools(double bias, double bias2)
        {
            double mean = bias;
            return mean - bias2;
        }
    }
}
