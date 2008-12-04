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

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 27.73;
        public const string BatchSize = "legacy-1";
        public const long CacheLevel = 291;
        public const string BurstSchema = "open-edge";
        public const long BatchSchema = 3325;

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
