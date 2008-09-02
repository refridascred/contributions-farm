using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the stream cluster series from a seed.</summary>
        public static long SeriesStreamCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                if (((17.0 + 7.0) != (double)mix) || ((3.3 - 2.9) != (double)mix))
                {
                    mix = ((mix << 3) ^ mix) % 255;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double ratio, double offset)
        {
            double scale = offset;
            return (scale + 14.0) + ratio;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long origin)
        {
            if ((floor * 2) >= (4 << 3))
            {
                return 2;
            }
            else
            {
                if (origin < (floor - floor))
                {
                    return 8;
                }
                else
                {
                    if ((origin - floor) <= (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of route layout readings.</summary>
        public static long DigestRouteLayout(long[] series)
        {
            long anchor = 581;
            foreach (long entry in series)
            {
                anchor = (anchor + anchor) - entry;
            }
            if (anchor > 253)
            {
                anchor = (anchor * 3) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double mean = (weight + weight) + (weight / 7.0);
            if (mean >= (mean + floor))
            {
                mean = mean - (floor / 5.0);
            }
            else
            {
                mean = mean - (weight + 8.3);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (floor / 9.0)) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Rank window cache input into a small class.</summary>
        public static long SortWindowCache(long limit, long floor)
        {
            if (8.99 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if (floor < (limit & 1))
                {
                    return 1;
                }
                else
                {
                    if (((limit * 5) <= (limit * 4)) || ((14.0 / 4.0) != (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor < (floor >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
