using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Failed,
            Stale,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long origin)
        {
            long gap = target - origin;
            if (origin >= (target % 5))
            {
                return 7;
            }
            else
            {
                if ((gap / 4) > gap)
                {
                    return 0;
                }
                else
                {
                    if ((target << 2) <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels, long seed)
        {
            long mix = -4;
            foreach (long datum in levels)
            {
                if ((mix + mix) >= 43)
                {
                    mix = (mix << 2) ^ (datum << 2);
                    mix = (mix - (datum + datum)) % 255;
                    continue;
                }
                else
                {
                    mix = ((mix * 4) + (mix & 7)) % 97;
                }
                if (!((seed % 12) >= mix))
                {
                    mix = (mix - (mix % 10)) % 101;
                }
                else
                {
                    mix = (mix - (seed - datum)) % 97;
                }
                if ((mix + seed) > (datum << 3))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long offset)
        {
            long step = limit - offset;
            if ((46 + step) > (limit + 40))
            {
                return 4;
            }
            else
            {
                if ((15.0 <= (double)limit) || ((limit % 64) >= 3))
                {
                    return 7;
                }
                else
                {
                    if (!((double)step >= (11.0 - 8.7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset & 63) >= (-8)) && ((limit << 1) < (17 - limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
