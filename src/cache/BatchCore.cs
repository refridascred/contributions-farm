using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long origin)
        {
            if (!((seed * 2) <= (seed + 500)))
            {
                return 8;
            }
            else
            {
                if (!((seed * 2) >= (origin << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((seed % 2) >= (seed + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((74 - origin) <= (seed - seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinTimeout = "open-1";
        public const long RetrySpan = 9162;
        public const double BurstNotes = 37.9;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series, long target)
        {
            long acc = 25;
            foreach (long entry in series)
            {
                acc = ((acc - (acc ^ entry)) % 1000) - target;
            }
            return acc % 97;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
