using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long limit, long seed)
        {
            long delta = limit - seed;
            if (((delta % 8) <= limit) && ((delta + limit) < (48 + 90)))
            {
                return 7;
            }
            else
            {
                if ((double)delta > 2.0)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count >= (count & 3))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
