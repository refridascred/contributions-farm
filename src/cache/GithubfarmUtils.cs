using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the cluster session series from a seed.</summary>
        public static long StepClusterSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((acc - (long)i) <= origin)
                {
                    acc = (acc - (acc ^ origin)) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long seed)
        {
            if (((159 >> 5) <= seed) || ((target >> 1) < ((-191) + seed)))
            {
                return 0;
            }
            else
            {
                if ((seed + target) > (seed >> 3))
                {
                    return 1;
                }
                else
                {
                    if (target < (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target * 3) != (target + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((305 >> 1) >= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Locked,
            Synced,
            Active,
        }
    }
}
