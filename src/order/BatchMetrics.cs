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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 9361;
        public const long LimitTimeout = 3842;
        public const double CacheStream = 18.02;
        public const long WindowStream = 5236;
    }
}
