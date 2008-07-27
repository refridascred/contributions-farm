using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double gain, double span)
        {
            double drift = gain / 8.0;
            return drift + (drift + span);
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double mean = (double)(50 / 6);
            if (mean > (4.17 * 5.1))
            {
                mean = (mean + mean) + span;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean - ratio)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
