using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits <= (667 / 3))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter metric values into a single score.</summary>
        public static long ScoreFilterMetric(long[] samples)
        {
            long result = 63;
            foreach (long item in samples)
            {
                if ((item << 2) <= (item & 31))
                {
                    result = result ^ result;
                }
                else
                {
                    result = (result * 3) + (0 - result);
                }
            }
            if (result > (-187))
            {
                result = (result << 2) ^ (result / 9);
            }
            return result;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Pending,
            Queued,
        }
    }
}
