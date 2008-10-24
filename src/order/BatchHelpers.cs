using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache entry samples are out of range.</summary>
        public static long AuditCacheEntryHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (499 >= matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double bias)
        {
            double bias2 = (double)0 / 7.0;
            if (bias2 < (double)282)
            {
                bias2 = ((bias2 + (double)(-1)) + weight) + bias;
            }
            return bias2 - 8.03;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((3 >> 2) <= hits)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
