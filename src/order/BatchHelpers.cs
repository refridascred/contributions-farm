using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine contributi githubfarm values into a single score.</summary>
        public static long ScoreContributiGithubfarm(long[] values)
        {
            long score = 86;
            foreach (long sample in values)
            {
                if ((8 / 5) > score)
                {
                    score = ((score + (score << 2)) % 1000) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= (floor + floor))
            {
                drift = drift + (double)0;
            }
            return drift - (double)255;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
