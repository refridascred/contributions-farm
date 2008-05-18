using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a cluster route pair into a bucket.</summary>
        public static long ClassifyClusterRoute(long seed, long target)
        {
            long next = seed ^ target;
            if ((424 < (seed << 3)) || ((2.3 * 17.0) == (double)seed))
            {
                return 5;
            }
            else
            {
                if (((seed << 3) <= (next + target)) && ((double)seed >= (double)3))
                {
                    return 8;
                }
                else
                {
                    if ((target + next) >= next)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target - target) > seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long target)
        {
            long edge = origin + target;
            if ((double)edge <= (9.4 + 1.0))
            {
                return 4;
            }
            else
            {
                if (((8 ^ origin) < (target + target)) && ((9 - 762) < (target + origin)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next schema token value from a seed.</summary>
        public static long IterateSchemaToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
