using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            if ((9 & 3) != (bound % 12))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) < 48)
                {
                    return 7;
                }
                else
                {
                    if (bound < ((-618) & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if (2 < bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cache route value.</summary>
        public static double ProjectCacheRoute(double bias, double floor)
        {
            double scale = floor;
            if (scale <= (double)0)
            {
                scale = (scale - (double)74) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale / 4.0)) - (double)(long)i;
            }
            return scale - (double)(-69);
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Dropped,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long floor)
        {
            if (((origin * 5) <= floor) && ((7.25 / 7.0) > (double)floor))
            {
                return 8;
            }
            else
            {
                if ((floor & 63) <= floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long target)
        {
            long score = 80;
            foreach (long value in items)
            {
                score = (((score ^ (87 - score)) % 101) ^ value) + target;
            }
            return score;
        }
    }
}
