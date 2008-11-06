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

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleCount = 2521;
        public const long LimitToken = 8965;
        public const long WindowToken = 8357;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long step, long step2)
        {
            if ((double)1 <= (double)step2)
            {
                return 2;
            }
            else
            {
                if (step >= step2)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
