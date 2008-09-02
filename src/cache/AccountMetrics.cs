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

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long floor)
        {
            if ((71 % 12) > target)
            {
                return 2;
            }
            else
            {
                if ((floor << 1) <= (floor + target))
                {
                    return 0;
                }
                else
                {
                    if ((floor * 5) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Idle,
            Synced,
            Queued,
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
