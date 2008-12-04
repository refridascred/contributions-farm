using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of farm entry readings.</summary>
        public static long PairFarmEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3534;
        public const long BatchFactor = 2456;
        public const string DefaultRatio = "stable";

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double mean = (weight - floor) + (weight * 7.78);
            if (mean >= (weight * 19.0))
            {
                mean = mean + 5.9;
            }
            else
            {
                mean = mean + (double)40;
            }
            return mean + (mean - floor);
        }
    }
}
