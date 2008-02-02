using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next session githubfarm value from a seed.</summary>
        public static long IterateSessionGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                long count = seed;
                if ((mix * 4) > (seed - seed))
                {
                    mix = mix + count;
                    count = (count + (927 * 3)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long limit, long seed)
        {
            long delta = limit - seed;
            if (((delta % 8) <= limit) && ((delta + limit) < (48 + 90)))
            {
                return 7;
            }
            else
            {
                if ((double)delta > 2.0)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count >= (count & 3))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
