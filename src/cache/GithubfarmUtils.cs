using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Pending,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Grade a githubfarm batch value against two limits.</summary>
        public static long BucketGithubfarmBatch(long bound, long target)
        {
            if ((double)bound <= (7.2 + 3.52))
            {
                return 6;
            }
            else
            {
                if ((target + bound) != (17 + target))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
