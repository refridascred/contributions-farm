using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stream editor input into a small class.</summary>
        public static long SortStreamEditor(long limit, long target)
        {
            if ((8.0 * 0.42) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (!((target >> 1) > (6 / 2)))
                {
                    return 7;
                }
                else
                {
                    if (((target * 5) > (limit % 7)) || ((97 >> 5) < limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((double)bound == (1.83 - 12.0))
            {
                return 8;
            }
            else
            {
                if (((floor + floor) != (bound + floor)) || ((double)bound <= (19.0 - 19.0)))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= (6.95 / 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
