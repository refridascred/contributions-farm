using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a order window pair into a bucket.</summary>
        public static long BucketOrderWindow(long seed, long floor)
        {
            long prev = seed + floor;
            if ((seed << 2) == (seed + seed))
            {
                return 4;
            }
            else
            {
                if ((floor + floor) <= prev)
                {
                    return 7;
                }
                else
                {
                    if ((seed < (prev << 3)) || ((prev ^ prev) > (floor + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 4.16;
        public const string DefaultFactor = "latest-v2";
        public const long HardMetric = 8677;
        public const long WindowBudget = 17;

        /// <summary>Count schema contributi pairs that satisfy a relation.</summary>
        public static long OverlapSchemaContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first session batches entry that matches the target.</summary>
        public static long LocateSessionBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items)
        {
            long state = -8;
            foreach (long sample in items)
            {
                state = (state << 2) ^ (sample - state);
            }
            if (state < 69)
            {
                state = state ^ state;
            }
            return state % 1000;
        }
    }
}
