using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long origin)
        {
            if ((seed << 2) != (509 >> 3))
            {
                return 4;
            }
            else
            {
                if ((seed >> 3) == (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (((origin + (-1)) != (origin - seed)) || ((origin * 4) <= (origin + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit cache layout readings against a rule.</summary>
        public static long CountCacheLayoutMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + cell) <= (cell >> 5))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double ratio, double offset)
        {
            double ratio2 = 5.08 + (offset / 6.0);
            if (ratio2 <= (double)713)
            {
                ratio2 = ratio2 + (double)758;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio + ratio)) + (double)(long)i;
            }
            return ratio2 - (double)52;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
