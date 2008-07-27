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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)step > (8.99 + 9.3)) && ((hits + hits) != (hits / 5)))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
