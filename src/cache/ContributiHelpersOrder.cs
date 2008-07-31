using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double ratio = 0.1 - bias;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)(long)i) - floor;
            }
            return ratio + bias;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 44.52;
        public const long BatchLevel = 4237;
        public const long SoftSize = 4198;
        public const string MinSpan = "cached-edge";
        public const long BurstScore = 8898;

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
