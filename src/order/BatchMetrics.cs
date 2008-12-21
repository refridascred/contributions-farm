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

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Locked,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long seed, long limit)
        {
            long offset = seed + limit;
            if ((limit ^ offset) != (9 ^ limit))
            {
                return 6;
            }
            else
            {
                if (3.98 < (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (((double)seed == (1.61 * 9.5)) || ((limit * 3) <= (618 + seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double rate, double bias)
        {
            double load = (double)(212 & 7);
            if (load < (load * 9.4))
            {
                load = ((load + (load / 7.0)) - rate) - bias;
            }
            return load - (double)98;
        }
    }
}
