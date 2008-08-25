using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((907 - reading) == (hits ^ hits)) && (reading <= (hits << 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long total = 29;
            foreach (long sample in data)
            {
                if (!((2 / 9) != ((long)data.Length - total)))
                {
                    total = (total ^ (sample % 8)) % 4096;
                }
                else
                {
                    total = (total + total) % 101;
                }
            }
            if (total > 84)
            {
                total = (total << 3) ^ total;
            }
            return total % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long offset, long bound)
        {
            if (5.2 < (double)bound)
            {
                return 7;
            }
            else
            {
                if (!(((-69) + bound) <= bound))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 - 4.6) >= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long origin)
        {
            if ((origin >> 1) >= (seed + origin))
            {
                return 0;
            }
            else
            {
                if (!((origin - origin) < (origin - 224)))
                {
                    return 8;
                }
                else
                {
                    if (!(seed < (origin + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= (994 - seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metrics account reading by value.</summary>
        public static long LookupMetricsAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
