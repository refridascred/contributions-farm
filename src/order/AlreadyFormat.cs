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

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell + 6) != (cell - count)) || ((count - bound) == (count << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
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

        /// <summary>Combine already metric values into a single score.</summary>
        public static long FoldAlreadyMetric(long[] series)
        {
            long sum = -14;
            foreach (long cell in series)
            {
                if (((cell ^ sum) != (sum + sum)) || ((sum & 7) > cell))
                {
                    sum = (sum << 2) ^ (sum * 2);
                }
                if ((sum << 3) > (cell & 127))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
