using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFactor = 132;
        public const long MaxBudget = 4452;
        public const long RetryFormat = 3210;
        public const long IdleFormat = 5167;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((target % 60) != (hits >> 5))
                {
                    hits = (hits + 2) + entry;
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
