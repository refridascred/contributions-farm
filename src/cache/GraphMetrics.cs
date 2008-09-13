using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((-19) > (1 - origin))
                {
                    mark = (mark - (19 + origin)) % 97;
                }
                else
                {
                    mark = (mark - (mark + mark)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long offset)
        {
            if ((floor & 7) == (floor / 7))
            {
                return 2;
            }
            else
            {
                if (floor >= (floor + offset))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor > (2.0 / 3.0)) || (offset <= (floor + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)offset == (4.0 - 6.9)) && ((floor + offset) != (offset & 7)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double offset)
        {
            double drift = (offset + ratio) / 6.0;
            if (drift <= ratio)
            {
                drift = drift + (drift / 5.0);
            }
            return drift - 6.1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long step, long floor)
        {
            long cur = step ^ floor;
            if ((step >> 5) == (7 - cur))
            {
                return 6;
            }
            else
            {
                if ((floor / 2) <= cur)
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
