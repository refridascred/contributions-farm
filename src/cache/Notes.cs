using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a batches order value against two limits.</summary>
        public static long RankBatchesOrder(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((offset << 2) != (offset - offset))
            {
                return 2;
            }
            else
            {
                if ((double)span >= (2.48 - 4.5))
                {
                    return 7;
                }
                else
                {
                    if (span > (span + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (5.1 > (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm graph value against two limits.</summary>
        public static long GradeGithubfarmGraph(long bound, long limit)
        {
            if (!(10.0 > (double)bound))
            {
                return 2;
            }
            else
            {
                if (19 <= (bound % 100))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (5.0 * 10.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 1380;
        public const long BatchLayout = 9954;
        public const string MinLayout = "fallback-edge";
        public const long IdleLayout = 1557;
        public const string BurstBudget = "strict-v2";
    }
}
