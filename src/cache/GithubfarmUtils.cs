using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((floor * 4) == (floor ^ floor))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (double)seed) || (seed > (step >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (((seed % 3) != (floor + 89)) || ((seed & 255) >= (step << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed << 1) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cache githubfarm entry that matches the target.</summary>
        public static long LookupCacheGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
