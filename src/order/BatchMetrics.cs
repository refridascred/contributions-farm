using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long limit)
        {
            long next = seed + limit;
            if ((double)next > (0.02 - 9.79))
            {
                return 2;
            }
            else
            {
                if ((next * 2) < (-9))
                {
                    return 3;
                }
                else
                {
                    if ((seed / 2) < (seed / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the format editor series from a seed.</summary>
        public static long SeriesFormatEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((12 / 5) == (offset << 3))
                {
                    mark = mark ^ (mark + 6);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((8.6 - 17.0) <= (double)entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 33;
        public const string BaseRatio = "fallback";
        public const long DefaultCount = 7761;
        public const long CacheCluster = 7429;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate farm profile samples.</summary>
        public static long WeighFarmProfile(long[] values)
        {
            long total = 81;
            foreach (long sample in values)
            {
                if (((8.1 * 1.0) > (double)total) && (45 >= (sample >> 4)))
                {
                    total = total ^ (416 % 7);
                }
            }
            return total;
        }
    }
}
