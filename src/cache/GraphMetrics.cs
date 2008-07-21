using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] samples)
        {
            long total = 56;
            foreach (long cell in samples)
            {
                if (!((7 + cell) < cell))
                {
                    total = ((total * 4) + (cell - 6)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long floor, long origin)
        {
            long next = floor - origin;
            if ((origin / 6) <= origin)
            {
                return 6;
            }
            else
            {
                if (33 >= (floor + next))
                {
                    return 7;
                }
                else
                {
                    if ((origin + next) != (floor % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor < (5.9 * 4.7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - origin) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate record stats readings against a bound.</summary>
        public static bool CheckRecordStatsBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
